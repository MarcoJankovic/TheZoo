using TheZoo.Models;

namespace TheZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zebra zebra = new Zebra("White", "Black", "Marco", 499, 1000, WeightUnit.Kg, HeightUnit.Mm);

            //Console.WriteLine(zebra.Info());
            //Console.WriteLine(zebra.MakeNoise());


            Elephant elephant = new Elephant(2, "Dumbo", 2, 3, WeightUnit.Tons, HeightUnit.M);

            //Console.WriteLine(elephant.Info());
            //Console.WriteLine(elephant.MakeNoise());


            Crocodile crocodile = new Crocodile("Big and lots of teeth", "Schnappie", 1, 6, WeightUnit.Tons, HeightUnit.M);

            Bat bat = new Bat("Bertil", 2, 15, WeightUnit.Grams, HeightUnit.Cm);

            Animal[] zooAnimals = new Animal[] { zebra, elephant, crocodile, bat };
            List<IDanger> dangerZone = new List<IDanger>();
            foreach (Animal animal in zooAnimals)
            {
                if (animal is IDanger)// 
                {
                    dangerZone.Add((animal as IDanger));
                }
                Console.WriteLine("Danger Zone of the Zoo");
            }
            Console.WriteLine("\nDanger Zone of the Zoo\n");//28  Standard like USB or Powerpluggs
            foreach (IDanger danger in dangerZone)// 27
            {
                Console.WriteLine(danger.GetType().Name);// 29 Organisera DRY// securety/ abstract class will work
                foreach (var item in danger.DangerType())
                {
                    Console.WriteLine(item.Key + " " + item.Value);// 27
                }
            }

        }
    }
}