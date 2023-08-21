using CleanArchitecture.Application.Repositories;
using Dapper.Contrib.Extensions;
using System.Data;
using System.Threading.Tasks;

namespace CleanArchitecture.Persistence.Repositories;



public class Repository<T> : IRepository<T> where T : class
{
    private readonly IDbConnection _dbConnection;

    public Repository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbConnection.GetAllAsync<T>();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _dbConnection.GetAsync<T>(id);
    }

    public async Task InsertAsync(T entity)
    {
        await _dbConnection.InsertAsync(entity);
    }

    public async Task UpdateAsync(T entity)
    {
        await _dbConnection.UpdateAsync(entity);
    }

    public async Task DeleteAsync(int id)
    {
        var entityToDelete = await _dbConnection.GetAsync<T>(id);
        if (entityToDelete != null)
        {
            await _dbConnection.DeleteAsync(entityToDelete);
        }
    }


}