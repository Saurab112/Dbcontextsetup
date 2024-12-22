using Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



//adding DbContext as Service
builder.Services.AddDbContext<PersonsDbContext>(options =>
{
	options.UseSqlServer();
});

var app = builder.Build();
app.UseRouting();
app.Run();
