using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheZoo.Models
{
    public class Bat : Animal, IDanger
    {
        public Bat(string? name, double weight, double height, WeightUnit weightUnit, HeightUnit heightUnit) : base(name, weight, height, weightUnit, heightUnit)
        {
        }

        public Dictionary<string, int> DangerType()
        {
            Dictionary<string, int> dangerTypes = new Dictionary<string, int>();
            dangerTypes.Add("Bitten", 9);
            return dangerTypes;
        }

        public override string MakeNoise()
        {
            return $"Ultrasonic";
        }

    }
}
