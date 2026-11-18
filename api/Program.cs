using Level_2___Challenge_1___Full_Stack_Website.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IAddServices, AddServices>();
builder.Services.AddScoped<IHelloServices, HelloServices>();
builder.Services.AddScoped<ICompareServices, CompareServices>();
builder.Services.AddScoped<IMadLibServices, MadLibServices>();
builder.Services.AddScoped<IBallServices, BallServices>();
builder.Services.AddScoped<IRestaurantServices, RestaurantServices>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Frontend", policy =>
    {
        //letting our app know which origins and requests are allowed.
        policy.AllowAnyOrigin()
        //allows any content type
        .AllowAnyHeader()
        //allows and method
        .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("Frontend");

app.MapControllers();

app.Run();
