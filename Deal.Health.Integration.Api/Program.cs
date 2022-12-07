using Deal.Health.Integration.Domain.Handlers;
using Deal.Health.Integration.Domain.Repositories;
using Deal.Health.Integration.Infra.Data.Context;
using Deal.Health.Integration.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<DbContext>();

builder.Services.AddScoped<IPacienteRepository, PacienteRepository>();
builder.Services.AddScoped<PacienteHandler>();

builder.Services.AddScoped<IAlergiaRepository, AlergiaRepository>();
builder.Services.AddScoped<AlergiaHandler>();

builder.Services.AddScoped<IExameRepository, ExameRepository>();
builder.Services.AddScoped<ExameHandler>();

builder.Services.AddScoped<ICirurgiaRepository, CirurgiaRepository>();
builder.Services.AddScoped<CirurgiaHandler>();

builder.Services.AddScoped<IInstituicaoRepository, InstituicaoRepository>();
builder.Services.AddScoped<InstituicaoHandler>();

builder.Services.AddScoped<IColaboradorRepository, ColaboradorRepository>();
builder.Services.AddScoped<ColaboradorHandler>();

builder.Services.AddScoped<IDoencaRepository, DoencaRepository>();
builder.Services.AddScoped<DoencaHandler>();

builder.Services.AddScoped<IMedicacaoRepository, MedicacaoRepository>();
builder.Services.AddScoped<MedicacaoHandler>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
