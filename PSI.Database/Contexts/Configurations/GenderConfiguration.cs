using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PSI.Domain.Entities;

namespace PSI.Infrastructure.Contexts.Configurations;
internal class GenderConfiguration : IEntityTypeConfiguration<Gender>
{
	public void Configure(EntityTypeBuilder<Gender> entity)
	{
		entity.ToTable("Gender");

		entity.HasKey(e => e.Id);

		entity.Property(e => e.Name)
			.HasMaxLength(50)
			.IsUnicode(false);
	}
}
