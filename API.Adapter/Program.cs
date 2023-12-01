using API.Adapter.Application.DTO;
using API.Adapter.Application.Interfaces;
using API.Adapter.Application.Services;
using API.Adapter.Domain.Entities;
using API.Adapter.Domain.Interfaces;
using API.Adapter.Infra.Data.Repositories;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var config = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<PropostaBaseDto, PropostaBase>().ReverseMap();
    cfg.CreateMap<PropostaDto, Proposta>().ReverseMap();
    cfg.CreateMap<FaturamentoDto, Faturamento>().ReverseMap();
    cfg.CreateMap<EnderecoDto, Endereco>().ReverseMap();
    cfg.CreateMap<ContaBancoDto, ContaBanco>().ReverseMap();
});
IMapper mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IPropostaRepository, PropostaRepository>();
builder.Services.AddScoped<IPropostaServices, PropostaServices>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
