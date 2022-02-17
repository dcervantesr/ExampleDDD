using Tiendeo.Users.Infraestructure;
using Tiendeo.Users.Application;
using Tiendeo.Users.Domain;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<GetAllUsersUseCase>();
builder.Services.AddScoped<FindUserByIdUseCase>();
builder.Services.AddScoped<CreateUserUseCase>();
builder.Services.AddScoped<GetAllUsers>();
builder.Services.AddScoped<FindUser>();
builder.Services.AddScoped<CreateUser>();
builder.Services.AddSingleton<IUserRepository, InMemoryUserRepository>();


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
