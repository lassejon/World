using Sea.Enums;
using Sea.Models.BaseModels;
using Sea.Models.Fish;

namespace Sea.Repositories;

public class FishRepository
{
    public List<FishBaseModel> Fish { get; } = new()
    {
        new Shark
        {
            Eats = FishFood.Fish,
            LengthInCm = 121212,
            Name = "Karl",
            WeightInGrams = 1203123,
            Type = SharkType.GreatWhite
        },
        new Shark
        {
            Eats = FishFood.Fish,
            LengthInCm = 121212,
            Name = "Karl the Second",
            WeightInGrams = 120312312,
            Type = SharkType.GreatWhite
        },
        new Shark
        {
            Eats = FishFood.Fish,
            LengthInCm = 121212,
            Name = "Edgar",
            WeightInGrams = 120312312,
            Type = SharkType.Hammerhead
        },
        new Whale
        {
            BlowHoleDiameter = 15,
            Eats = FishFood.Fish,
            LengthInCm = 121212,
            Name = "Robert",
            WeightInGrams = 1203123,
            MaxSpeedInKmph = 100,
            Type = WhaleType.Blue,
        },
        new Whale
        {
            BlowHoleDiameter = 14,
            Eats = FishFood.Fish,
            LengthInCm = 121212,
            Name = "Marie",
            WeightInGrams = 1203123,
            MaxSpeedInKmph = 100,
            Type = WhaleType.Blue

        },
        new Whale
        {
            BlowHoleDiameter = 11,
            Eats = FishFood.Fish,
            LengthInCm = 121212,
            Name = "Delphine",
            WeightInGrams = 1203123,
            MaxSpeedInKmph = 100,
            Type = WhaleType.Sperm
        },
        new Fish
        {
            Eats = FishFood.Fish,
            LengthInCm = 121212,
            Name = "Bear",
            WeightInGrams = 1203123,
            Type = FishType.Salmon
        },
        new Fish
        {
            Eats = FishFood.Fish,
            LengthInCm = 121212,
            Name = "Bird",
            WeightInGrams = 1203123,
            Type = FishType.Stout
        }
    };
}