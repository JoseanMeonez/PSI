namespace Domain.Entities;

public partial class PhoneNumber : BaseEntity<int>
{
	public string Description { get; set; } = null!;

	public string Number { get; set; } = null!;

	public int CustomerId { get; set; }

	public virtual Customer Customer { get; set; } = null!;
}
