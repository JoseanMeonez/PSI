using Microsoft.EntityFrameworkCore;
using PSI.Domain.Entities;
using PSI.Infrastructure.Contexts;
using PSI.Infrastructure.Interfaces;

namespace PSI.Infrastructure.Repositories;

public class CustomerRepository : GenericRepository<Customer, int>, ICustomerRepository
{
	private readonly PsiContext _context;

	public CustomerRepository(PsiContext context) : base(context)
	{
		_context = context;
	}

	public Task<Customer?> GetByIdWithIncludes(int customerId)
	{
		return GetEntityQuery()
			.Include(c => c.Emails)
			.Include(c => c.Gender)
			.Include(c => c.IdentificationType)
			.Include(c => c.PhoneNumbers)
			.Include(c => c.Prospect)
			.Include(c => c.References)
			.FirstOrDefaultAsync(ea => ea.Id == customerId);
	}
}
