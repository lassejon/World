using System.Drawing;
using Sea.Enums;
using Sea.Models.BaseModels;

namespace Sea.Models.Fish;

public class Whale : FishBaseModel
{
    public int BlowHoleDiameter { get; set; }

    public WhaleType Type { get; set; }

    public int MaxSpeedInKmph { get; set; }

    public override string ToString()
    {
        return $"{Type} {GetType().Name} {base.ToString()} max speed: {MaxSpeedInKmph}";
    }
}