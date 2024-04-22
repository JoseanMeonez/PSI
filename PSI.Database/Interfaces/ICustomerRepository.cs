﻿using PSI.Domain.Entities;

namespace PSI.Infrastructure.Interfaces;

public interface ICustomerRepository
{
	/// <summary>
	/// Gets the customer with the specified identifier and its related references eagerly loaded.
	/// </summary>
	/// <param name="customerId">The unique identifier of the customer.</param>
	/// <returns>The customer entity with its related references loaded, or null if not found.</returns>
	Task<Customer?> GetByIdWithIncludes(int customerId);
}