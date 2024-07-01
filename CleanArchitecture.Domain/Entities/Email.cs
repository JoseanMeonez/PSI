namespace Domain.Entities;

public partial class Email : BaseEntity<int>
{
	public required string Description { get; set; }

	public required string EmailName { get; set; }

	public int CustomerId { get; set; }

	public virtual Customer? Customer { get; set; }
}
