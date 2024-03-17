using IcecreamMAUI.Api.Data;
using IcecreamMAUI.Api.Endpoints;
using IcecreamMAUI.Api.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultString")));

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(jwtoptions =>
    {
        jwtoptions.TokenValidationParameters = TokenService.GetTokenValidationParameters(builder.Configuration);
    });

builder.Services.AddAuthorization();

builder.Services.AddTransient<TokenService>()
                .AddTransient<PasswordService>()
                .AddTransient<AuthService>();

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

app.UseAuthentication();
app.UseAuthorization();
app.MapEndPoints();
app.MapControllers();

app.Run();

static void MigrationDatabase(IServiceProvider service)
{
    var scope = service.CreateScope();
    var dataContext = scope.ServiceProvider.GetRequiredService<DataContext>();
    if (dataContext.Database.GetPendingMigrations().Any())
        dataContext.Database.Migrate();
}