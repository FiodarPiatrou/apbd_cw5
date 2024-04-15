using Cw5.Models;

namespace Cw5.Database;

public class StaticData
{
    public static List<Animal> Animals = new List<Animal>()
    {
        new Animal(){HairColor = "grey",Id = 0,Name = "Zyza",Type = "cat"},
        new Animal(){HairColor = "orange",Id = 1,Name = "Garfield",Type = "cat"},
        new Animal(){HairColor = "black",Id = 2,Name = "Beast of darkness",Type = "dog"}

    };

    public static List<Visit> Visits = new List<Visit>()
    {
        new Visit() { Animal = Animals[0], Date = "2020-01-01", Description = "Grooming", Price = 39.99 },
        new Visit() { Animal = Animals[1], Date = "2023-12-31", Description = "Training", Price = 19.99 },
        new Visit() { Animal = Animals[2], Date = "2024-02-11", Description = "Therapy", Price = 69.99 }
    };
}