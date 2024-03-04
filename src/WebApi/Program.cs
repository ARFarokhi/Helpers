using Asp.Versioning;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Services;
using WebApi.Services.PaymentService;


var builder = WebApplication.CreateBuilder(args);

//keyed services
builder.Services.AddKeyedSingleton<IPaymentService, MasterCardPaymentService>(Payment.MasterCard);
builder.Services.AddKeyedSingleton<IPaymentService, PaypalPaymentService>(Payment.Paypal);
builder.Services.AddKeyedSingleton<IPaymentService, CryptoPaymentService>(Payment.Crypto);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddApiVersioning(options =>
    {
        options.DefaultApiVersion = new ApiVersion(1, 0);
        options.AssumeDefaultVersionWhenUnspecified = true;
        options.ReportApiVersions = true;
    })
    .AddApiExplorer(options =>
    {
        options.GroupNameFormat = "'v'VVV";
        options.SubstituteApiVersionInUrl = true;
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IReportService, ReportService>();
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
