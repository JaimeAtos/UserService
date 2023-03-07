using Persistence;
using Application;
using Shared;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.
/*var connectionString = configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<UserServiceDbContext>(options => options.UseSqlServer(connectionString));*/
builder.Services.AddApplicationLayer();
builder.Services.AddSharedInfraestructure();
builder.Services.AddPersistence(configuration);
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