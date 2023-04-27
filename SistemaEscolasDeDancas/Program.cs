using EscolasDeDanca.Repository.AlunosRepositories;
using EscolasDeDanca.Services.AlunosServices;
using SistemaEscolasDeDanca.EscolasDeDancas.API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

ConfigureServices(builder.Services);

var conStrBuilder = new MySqlConnectionStringBuilder(
        builder.Configuration.GetConnectionString("MySql"));
conStrBuilder.Password = builder.Configuration["ConnectionStringPassword:Intech"];
var connection = conStrBuilder.ConnectionString;

builder.Services.AddDbContext<EscolasDancaContext>(options =>
options.UseMySQL(connection));

var CorsPolicy = "CorsPolicy";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: CorsPolicy, builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(CorsPolicy);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

void ConfigureServices(IServiceCollection services)
{
    //AlunosController Injections
    services.AddTransient<IAlunoService, AlunoService>();
    services.AddTransient<IAlunoRepository, AlunoRepository>();


}