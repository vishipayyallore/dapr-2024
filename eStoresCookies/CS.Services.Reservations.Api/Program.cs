WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

JsonSerializerOptions jsonOptions = new()
{
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    PropertyNameCaseInsensitive = true,
};

// Add services to the container.
builder.Services.AddDaprClient(opt => opt.UseJsonSerializationOptions(jsonOptions));

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

//app.UseHttpsRedirection();

app.MapPost("/reserve", ([FromServices] DaprClient client, [FromBody] Item item) =>
{
    app.Logger.LogInformation("Enter Reservation");

    Item storedItem = new()
    {
        SKU = item.SKU
    };
    storedItem.Quantity -= item.Quantity;

    app.Logger.LogInformation($"Reservation of {storedItem.SKU} is now {storedItem.Quantity}");

    return Results.Ok(storedItem);
})
    .WithOpenApi()
    .WithTags("Welcome.API")
    .WithName("GetRootWelcome"); ;

app.Run();

