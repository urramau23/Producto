using Productos.API.Configurations;
using Productos.API.Filters;
using Productos.Core.Entities.DTO;
using Productos.Core.Entities.Exceptions;
using Productos.Core.Interfaces;
using Productos.Core.Services;
using Productos.Infrastructure.Gateway;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
// agregar Healthcheck
builder.Services.AddHealthChecks();

// configuracion de serilog
builder.Host.UseSerilog((hostingContext, loggerConfiguration) =>
    loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration));

// Obtencion de parametros
IConfigurationSection parametros = builder.Configuration.GetSection("Parametros");
builder.Services.Configure<Parametros>(parametros);

// Add services to the container.
builder.Services.AddScoped<ModelValidationFilter>();
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.IgnoreNullValues = true;
        options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
        options.JsonSerializerOptions.WriteIndented = true;
    }).
    ConfigureApiBehaviorOptions(options => options.SuppressModelStateInvalidFilter = true).
    AddXmlDataContractSerializerFormatters();

// Clientes http
var epCoreTarjeta = builder.Configuration.GetValue<string>("Endpoints:WsPrepaga");
if (String.IsNullOrEmpty(epCoreTarjeta)) throw new InternalServerErrorException("FALTA_VALOR_CONFIGURACION", "No se cargo la URL de CoreTarjeta.");
builder.Services.AddHttpClient(HttpClientNames.CoreTarjeta, c =>
{
    c.BaseAddress = new Uri(epCoreTarjeta);
    c.Timeout = TimeSpan.FromSeconds(10);
});

// Registrar Servicio
builder.Services.AddTransient<ICoreTarjetasGateway,CoreTarjetasGateway>();
builder.Services.AddTransient<ITarjetaCreditoServices, TarjetaCreditoServices>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.AddApplicationHealthCheck();

app.UseSerilogRequestLogging();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

//registro el middleware
app.AddGlobalErrorHandler();

app.MapControllers();

app.Run();
