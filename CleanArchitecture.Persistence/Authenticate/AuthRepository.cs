using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
 
 
namespace CleanArchitecture.Persistence.Authenticate;



public class AuthRepository : IAuthRepository
{
    private List<Login> _logins = new List<Login>
        {
            new Login { Id = 1, FirstName = "Admin", LastName = "User", Username = "admin", Password = "admin", Role = Role.Admin },
            new Login { Id = 2, FirstName = "Normal", LastName = "User", Username = "user", Password = "user", Role = Role.User }
        };


    public IEnumerable<Login> GetAll()
    {
        return _logins.WithoutPasswords();
    }

    public Login GetById(int id)
    {
        var login = _logins.FirstOrDefault(x => x.Id == id);
        return login.WithoutPassword();
    }

    public Login GetLogin(string username, string password)
    {
        var login = _logins.SingleOrDefault(x => x.Username == username && x.Password == password);
        return login.WithoutPassword();
    }



 
 
}