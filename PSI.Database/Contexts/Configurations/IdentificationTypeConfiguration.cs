using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PSI.Domain.Entities;

namespace PSI.Infrastructure.Contexts.Configurations;
internal class IdentificationTypeConfiguration : IEntityTypeConfiguration<IdentificationType>
{
	public void Configure(EntityTypeBuilder<IdentificationType> entity)
	{
		entity.ToTable("IdentificationType");

		entity.Property(e => e.Name)
			.HasMaxLength(50)
			.IsUnicode(false);
	}
}
