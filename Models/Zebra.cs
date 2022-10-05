using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheZoo.Models
{
    public class Zebra : Animal, IDanger
    {
        public Zebra(string? stripes, string? furColor, string? name, double weight, double height, WeightUnit weightUnit, HeightUnit heightUnit) : base(name, weight, height, weightUnit, heightUnit)
        {
            Stripes = stripes;
            FurColor = furColor;
        }

        public string? Stripes { get; set; }
        public string? FurColor { get; set; }

        public override string MakeNoise()
        {
            return "HeeHaa!";
        }

        public override string Info()
        {
            return base.Info() + $"\nFur {FurColor} with {Stripes} stripes";
        }

        public Dictionary<string, int> DangerType()
        {
            Dictionary<string, int> dangerTypes = new Dictionary<string, int>();
            dangerTypes.Add("Kicked", 9);
            dangerTypes.Add("Bite", 5);
            return dangerTypes;
        }
    }
}
