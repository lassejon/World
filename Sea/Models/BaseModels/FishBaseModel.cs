using System.Drawing;
using Sea.Enums;

namespace Sea.Models.BaseModels;

public class FishBaseModel
{
    public FishFood Eats { get; set; }
    
    public string Name { get; set; }
    
    public int LengthInCm { get; set; }
    
    public int WeightInGrams { get; set; }

    public void Eat(FishFood food)
    {
        Console.WriteLine($"{Name} eats {food}");
    }

    public override string ToString()
    {
        return $"length: {LengthInCm} weight: {WeightInGrams}";
    }
}