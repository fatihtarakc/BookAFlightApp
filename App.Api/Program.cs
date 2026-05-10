var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDataAccessServices(builder.Configuration);
builder.Services.AddDataAccessConcreteServices(builder.Configuration);
builder.Services.AddCacheServices(builder.Configuration);
builder.Services.AddBusinessServices(builder.Configuration);
builder.Services.AddQueueServices(builder.Configuration);
builder.Services.AddBackgroundJobsServices(builder.Configuration);
builder.Services.AddApiServices();

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

app.AddUseRequestLocalizationApplicationBuilder();
app.AddBackgroundJobsUseHangfireDashboardWithPathApplicationBuilder("/hangfire");

app.UseHttpsRedirection();
app.UseCors("BookAFlightAppCors");
app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();
