namespace Application.Services.Jwt;

public interface IJwtService
{
	public string GetSubjectToken();
	public Guid GetUidToken();
}
