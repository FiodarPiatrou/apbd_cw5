using Cw5.Database;
using Cw5.Models;

namespace Cw5.Endpoints;

public static class VisitEndpoints
{
    public static void MapVisitEndpoints(this WebApplication app)
    {
        app.MapPost("/visits", (Visit visit) =>
        {
            if (StaticData.Visits.Exists(visit1 =>StaticData.Animals.Contains(visit.Animal)))
            {
                StaticData.Visits.Add(visit);
                return Results.Created("", visit);
            }

            return Results.BadRequest("No such animal in database");
        });
        app.MapGet("/visits", (Animal animal) =>
        {
            var animalVisits = new List<Visit>();
            if (!StaticData.Visits.Exists(visit => visit.Animal==animal))
            {
                return Results.BadRequest("No such visits with given animal");
            }
            foreach (var visit in StaticData.Visits)
            {
                if (visit.Animal==animal)
                {
                    animalVisits.Add(visit);
                }
            }

            return Results.Ok(animalVisits);
        });
    }
}