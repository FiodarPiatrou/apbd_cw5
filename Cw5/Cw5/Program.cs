var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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
//Minimal API
app.MapGet("/animals", () =>
{
    //200-Ok
    //404 -Not found
    //403 - Forbidden
    //401 - Unauthorized
    //400 - Bad request
    //201 - Create
    return Results.Ok();
} );
app.MapGet("/animals/{id}", (int id) =>
{
    return Results.Ok(id);
});
app.MapPost("/animals", () =>
{
    return Results.Created();
});

app.Run();
