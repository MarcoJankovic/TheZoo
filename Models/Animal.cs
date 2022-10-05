using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheZoo.Models
{
    public abstract class Animal
    {
        public string? Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public WeightUnit WeightUnit { get; set; }
        public HeightUnit HeightUnit { get; set; }


        public Animal(string? name, double weight, double height, WeightUnit weightUnit, HeightUnit heightUnit)
        {
            Name = name;
            Weight = weight;
            Height = height;
            WeightUnit = weightUnit;
            HeightUnit = heightUnit;
        }

        public abstract string MakeNoise();

        public virtual string Info()
        {
            return $"-----{this.GetType().Name}----- \nName: {Name} \nWeight: {Weight} {WeightUnit}\nHeight: {Height} {HeightUnit}";
        }

    }
}
