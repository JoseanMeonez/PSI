using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PSI.Domain.Entities;

namespace PSI.Infrastructure.Contexts.Configurations;
internal class ReferenceConfiguration : IEntityTypeConfiguration<Reference>
{
	public void Configure(EntityTypeBuilder<Reference> entity)
	{
		entity.ToTable("Reference");

		entity.Property(e => e.Name)
			.HasMaxLength(100)
			.IsUnicode(false);

		entity.Property(e => e.PhoneNumber)
			.HasMaxLength(8)
			.IsUnicode(false);

		entity.Property(e => e.Relationship)
			.HasMaxLength(100)
			.IsUnicode(false);

		entity.HasOne(d => d.Customer).WithMany(p => p.References)
			.HasForeignKey(d => d.CustomerId)
			.OnDelete(DeleteBehavior.ClientSetNull)
			.HasConstraintName("FK_Reference_Customer");
	}
}
