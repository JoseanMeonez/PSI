using Microsoft.EntityFrameworkCore;
using PSI.Api;
using PSI.Application;
using PSI.Infrastructure.Contexts;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
	.AddPresentation()
	.AddApplicationLayer(builder.Configuration)
	.AddRepositories()
	.AddCors(options =>
	{
		options.AddDefaultPolicy(policy =>
		{
			policy.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost")
				.AllowAnyHeader()
				.AllowAnyMethod()
				.AllowCredentials();
		});
	})
	.AddDbContext<PsiContext>(options =>
	{
		options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseContext"));
	});

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

if (app.Environment.IsProduction())
{

}

app.UseErrorHandlingMiddleware();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
