namespace PSI.Domain.Entities;

public partial class Reference : BaseEntity<int>
{
	public string Name { get; set; } = null!;

	public string PhoneNumber { get; set; } = null!;

	public string Relationship { get; set; } = null!;

	public int CustomerId { get; set; }

	public virtual Customer Customer { get; set; } = null!;
}
