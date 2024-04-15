using Cw5.Database;
using Cw5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cw5.Endpoints;

public static class VisitEndpoints
{
    public static void MapVisitEndpoints(this WebApplication app)
    {
        app.MapPost("/visits", (Visit visit) =>
        {
            if (!StaticData.Animals.Contains(visit.Animal))
            {
                StaticData.Visits.Add(visit);
                return Results.Created("", visit);
            }

            return Results.BadRequest("No such animal in database");
        });
        app.MapGet("/visits/{id}", (int id) =>
        {
            var animalVisits = new List<Visit>();
            if (!StaticData.Visits.Exists(visit => visit.Animal==StaticData.Animals[id]))
            {
                return Results.BadRequest("No such visits with given animal");
            }
            foreach (var visit in StaticData.Visits)
            {
                if (visit.Animal==StaticData.Animals[id])
                {
                    animalVisits.Add(visit);
                }
            }

            return Results.Ok(animalVisits);
        });
    }
}