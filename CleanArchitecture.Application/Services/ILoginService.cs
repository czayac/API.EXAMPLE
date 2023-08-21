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

public interface ILoginService
{
    Login Authenticate(string username, string password);
    IEnumerable<Login> GetAll();
    Login GetById(int id);
}

    
 