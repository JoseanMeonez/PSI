using Domain.Entities;
using System.Linq.Expressions;

namespace Infrastructure.Interfaces;

public interface IGenericRepository<T, TId>
		where T : BaseEntity<TId>
{
	/// <summary>
	/// Retrieves all entities from the repository asynchronously.
	/// </summary>
	/// <returns>A task that represents the asynchronous operation, returning a collection of entities.</returns>
	Task<IEnumerable<T>> GetAllAsync();

	/// <summary>
	/// Retrieves a single entity based on its unique identifier asynchronously.
	/// </summary>
	/// <param name="id">The unique identifier of the entity.</param>
	/// <returns>A task that represents the asynchronous operation, returning the entity if found; otherwise, null.</returns>
	Task<T?> GetByIdAsync(TId id);

	/// <summary>
	/// Checks if any entities in the repository match the given condition asynchronously.
	/// </summary>
	/// <param name="predicate">The condition to match entities.</param>
	/// <returns>A task that represents the asynchronous operation, returning true if any entity matches the condition; otherwise, false.</returns>
	Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);

	/// <summary>
	/// Retrieves an IQueryable representing a subset of entities based on the provided criteria.
	/// </summary>
	/// <param name="filter">The criteria to filter entities.</param>
	/// <returns>IQueryable representing the subset of entities matching the criteria.</returns>
	IQueryable<T> GetEntityQuery(Expression<Func<T, bool>>? filter = null);

	/// <summary>
	/// Adds a new entity to the repository asynchronously.
	/// </summary>
	/// <param name="entity">The entity to add.</param>
	/// <returns>A task that represents the asynchronous operation, returning the added entity.</returns>
	Task<T> InsertAsync(T entity);

	/// <summary>
	/// Adds a collection of entities to the repository asynchronously.
	/// </summary>
	/// <param name="entities">The collection of entities to add.</param>
	/// <returns>A task that represents the asynchronous operation, returning the collection of entities to add.</returns>
	Task<IEnumerable<T>> InsertRangeAsync(IEnumerable<T> entities);

	/// <summary>
	/// Updates an existing entity in the repository.
	/// </summary>
	/// <param name="entity">The entity to update.</param>
	void Update(T entity);

	/// <summary>
	/// Updates a collection of entities in the repository synchronously.
	/// </summary>
	/// <param name="entities">The collection of entities to update.</param>
	void UpdateRange(IEnumerable<T> entities);

	/// <summary>
	/// Deletes an entity from the repository asynchronously.
	/// </summary>
	/// <param name="id">The unique identifier of the entity.</param>
	/// <returns>A task that represents the asynchronous operation, returning true if the entity was deleted; otherwise, false.</returns>
	Task<bool> DeleteAsync(TId id);

	/// <summary>
	/// Asynchronously saves all changes made in this context to the underlying database.
	/// </summary>
	/// <param name="cancellationToken">
	/// <returns>A task that represents the asynchronous operation, the result of the task contains the number of status entries written to the underlying database.</returns>
	Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
