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
}