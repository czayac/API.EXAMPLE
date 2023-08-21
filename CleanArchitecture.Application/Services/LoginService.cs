using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using CleanArchitecture.Application.Common.Settings;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;


namespace CleanArchitecture.Application.Services; 

    public class LoginService : ILoginService
    {
        private readonly AppSettings _appSettings;
        private readonly IAuthRepository _authRepository;

        public LoginService(IOptions<AppSettings> appSettings, IAuthRepository authRepository)
        {
            _appSettings = appSettings.Value;
            _authRepository = authRepository;
        }

        public Login Authenticate(string username, string password)
        {
            var login = _authRepository.GetLogin(username, password);

            // return null if user not found
            if (login == null)
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] 
                {
                    new Claim(ClaimTypes.Name, login.Id.ToString()),
                    new Claim(ClaimTypes.Role, login.Role)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            login.Token = tokenHandler.WriteToken(token);

            return login;
        }

        public IEnumerable<Login> GetAll()
        {
            return _authRepository.GetAll();
        }

        public Login GetById(int id) 
        {     
            return _authRepository.GetById(id);    
        }
    }
 