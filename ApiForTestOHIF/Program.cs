using ApiForTestOHIF;
using ApiForTestOHIF.Factories;
using ApiForTestOHIF.Services;
using ApiForTestOHIF.Storage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();
builder.Services.AddHealthChecks();



builder.Services.AddScoped<IObjectArchieveQueryService, ObjectArchieveQueryService>();
builder.Services.AddScoped<IOhifService, OhifService>();
builder.Services.AddScoped<IQueryOptions, QueryOptions>();
builder.Services.AddScoped<IRetrieveUrlProvider, RetrieveUrlProvider>();
builder.Services.AddScoped<IWadoRsService, WadoRsService>();
builder.Services.AddScoped<IWadoUriService, WadoUriService>();
builder.Services.AddScoped<IObjectRetrieveService, ObjectRetrieveService>();
builder.Services.AddScoped<IDicomMediaIdFactory, DicomMediaIdFactory>();
builder.Services.AddScoped<IDicomMediaWriterFactory, DicomMediaWriterFactory>();
builder.Services.AddScoped<IMediaStorageService, FileStorageService>();



var app = builder.Build();



    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.UseHealthChecks("/health");

app.UseCors(builder => builder
.AllowAnyHeader()
.AllowAnyMethod()
.SetIsOriginAllowed((host) => true)
.AllowCredentials());

app.Run();
