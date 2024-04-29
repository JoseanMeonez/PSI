using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts;

/// <summary>
/// Represents the application database context.
/// </summary>
public partial class PsiContext : DbContext
{
	/// <summary>
	/// Initializes a new instance of the <see cref="PsiContext"/> class.
	/// </summary>
	/// <param name="options">The database context options.</param>
	public PsiContext(DbContextOptions<PsiContext> options) : base(options)
	{
		ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
	}

	public virtual DbSet<Customer> Customers { get; set; }

	public virtual DbSet<Email> Emails { get; set; }

	public virtual DbSet<Gender> Genders { get; set; }

	public virtual DbSet<IdentificationType> IdentificationTypes { get; set; }

	public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }

	public virtual DbSet<Prospect> Prospects { get; set; }

	public virtual DbSet<Reference> References { get; set; }

	/// <inheritdoc />
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => base.OnConfiguring(optionsBuilder);

	/// <inheritdoc />
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		OnModelCreatingPartial(modelBuilder);
		modelBuilder.ApplyConfigurationsFromAssembly(typeof(PsiContext).Assembly);
	}

	/// <inheritdoc />
	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
