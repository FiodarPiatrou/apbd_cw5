using Cw5.Database;
using Cw5.Models;

namespace Cw5.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        app.MapGet("/animals", () =>
        {
            //200-Ok
            //404 -Not found
            //403 - Forbidden
            //401 - Unauthorized
            //400 - Bad request
            //201 - Created
            var animals = StaticData.Animals;
            return Results.Ok(animals);
        } );
        app.MapGet("/animals/{id}", (int id) =>
        {
            return Results.Ok(StaticData.Animals[id]);
        });
        app.MapPost("/animals", (Animal animal) =>
        {
            if (StaticData.Animals.Exists((animal1 => animal1.Id==animal.Id )))
            {
                return Results.BadRequest("Animal with a given id exists");
            }
            StaticData.Animals.Add(animal);
            return Results.Created("",animal);
        });
    }
}