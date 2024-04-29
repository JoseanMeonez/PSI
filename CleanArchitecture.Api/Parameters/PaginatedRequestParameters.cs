namespace Api.Parameters;

public record PaginatedRequestParameters(
	string? SearchParameter,
	string? SortColumn,
	string? SortOrder,
	bool All,
	int Page = 1,
	int PageSize = 10);
