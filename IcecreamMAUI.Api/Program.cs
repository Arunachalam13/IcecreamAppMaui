using IcecreamMAUI.Api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultString")));

var app = builder.Build();

#if DEBUG
MigrationDatabase(app.Services);
#endif

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

static void MigrationDatabase(IServiceProvider service)
{
    var scope = service.CreateScope();
    var dataContext = scope.ServiceProvider.GetRequiredService<DataContext>();
    if (dataContext.Database.GetPendingMigrations().Any())
        dataContext.Database.Migrate();
}