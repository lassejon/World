using System.Drawing;
using Sea.Enums;
using Sea.Models.BaseModels;

namespace Sea.Models.Fish;

public sealed class Shark : FishBaseModel
{
    public SharkType Type { get; set; }
    
    public void Eat(WeirdFishFood food)
    {
        Console.WriteLine($"{Name} eats {food} argggg");
    }
    
    public override string ToString()
    {
        return $"{Type} {GetType().Name} {base.ToString()}";
    }
}