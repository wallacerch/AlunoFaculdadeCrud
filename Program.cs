using AlunoFaculdadeCrud.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DataContext>(options => options.UseNpgsql(connectionString));
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();