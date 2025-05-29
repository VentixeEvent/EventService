using Data.Models;
using System.Linq.Expressions;


namespace Data.Interfaces;

public interface IBaseRepository<TEntity> where TEntity : class
{
    Task<RepositoryResult<IEnumerable<TEntity>>> GetAllAsync();
    Task<RepositoryResult<TEntity?>> GetAsync(Expression<Func<TEntity, bool>> expression);
    Task<RepositoryResult> AlreadyExistsAsync(Expression<Func<TEntity, bool>> expression);
    Task<RepositoryResult> AddAsync(TEntity entity);
    Task<RepositoryResult> UpdateAsync(TEntity entity);
    Task<RepositoryResult> DeleteAsync(TEntity entity);
}
