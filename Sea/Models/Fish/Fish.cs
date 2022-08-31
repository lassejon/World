using System.Drawing;
using Sea.Enums;
using Sea.Models.BaseModels;
using Sea.Repositories;

namespace Sea.Models.Fish;

public class Fish : FishBaseModel
{
    public FishType Type { get; set; }
    
    public override string ToString()
    {
        return $"{Type} {GetType().Name} {base.ToString()}";
    }
}