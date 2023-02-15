using ApiForTestOHIF.Dicoms;
using ApiForTestOHIF.Dicoms.Retrieve;
using ApiForTestOHIF.Factories;
using ApiForTestOHIF.Models;
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





builder.Services.AddScoped<IQueryOptions, QueryOptions>();
builder.Services.AddScoped<IRetrieveUrlProvider, RetrieveUrlProvider>();


builder.Services.AddScoped<IDicomMediaIdFactory, DicomMediaIdFactory>();
builder.Services.AddScoped<IDicomMediaWriterFactory, DicomMediaWriterFactory>();
builder.Services.AddScoped<IMediaStorageService, FileStorageService>();
builder.Services.AddScoped<IWadoUriRequest, WadoUriRequest>();

builder.Services.AddScoped<IObjectArchieveQueryService, ObjectArchieveQueryService>();
builder.Services.AddScoped<IObjectRetrieveService, ObjectRetrieveService>();
builder.Services.AddScoped<IObjectStoreService, ObjectStoreService>();

builder.Services.AddScoped<IWadoRsStudiesRequest, WadoRsStudiesRequest>();
builder.Services.AddScoped<IWadoRsSeriesRequest, WadoRsSeriesRequest>();
builder.Services.AddScoped<IDCloudCommandFactory, DCloudCommandFactory>();
//
//builder.Services.AddScoped<IObjectStoreService, ObjectStoreService>();
builder.Services.AddScoped<IWadoRsService, WadoRsService>();
builder.Services.AddScoped<IWadoUriService, WadoUriService>();
builder.Services.AddScoped<IOhifService, OhifService>();

//builder.Services.AddScoped<IWebObjectStoreService, WebObjectStoreService>();
//builder.Services.AddScoped<IQidoRsService, QidoRsService>();
IRetrieveUrlProvider urlProvider = new RetrieveUrlProvider("wadoRsUrl",
                                                            "wadoUriUrl");


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
