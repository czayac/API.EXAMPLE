using CleanArchitecture.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CleanArchitecture.Application.Repositories;

public interface IAuthRepository   { 

    public IEnumerable<Login> GetAll();       
    public Login GetById(int id);
    public Login GetLogin(string username, string password);

}