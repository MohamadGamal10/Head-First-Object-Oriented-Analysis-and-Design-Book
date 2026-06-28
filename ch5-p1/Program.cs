using ch5_p1.enums;

namespace ch5_p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guitar[] data = new Guitar[]
            {
                new Guitar("123", 1000, new GuitarSpecs(BuilderEnum.Fender, "Stratocaster", TypeEnum.Electric, WoodEnum.Alder, WoodEnum.Alder, 6)),
                new Guitar("124", 1500, new GuitarSpecs(BuilderEnum.Gibson, "Les Paul", TypeEnum.Electric, WoodEnum.Mahogany, WoodEnum.Maple, 12)),
                new Guitar("125", 2000, new GuitarSpecs(BuilderEnum.Martin, "D-28", TypeEnum.Acoustic, WoodEnum.Rosewood, WoodEnum.Spruce, 6)),
                new Guitar("126", 2500, new GuitarSpecs(BuilderEnum.Taylor, "814ce", TypeEnum.Acoustic, WoodEnum.Mahogany, WoodEnum.Spruce, 12)),
            };
            Inventory inventory = new Inventory(data);

            var guitar = new GuitarSpecs(null, "", TypeEnum.Electric, null, null, null);
            var result = inventory.search<Guitar>(guitar);

            if (result.Length > 0)
            {
                foreach (var item in result)
                {
                    Console.WriteLine($"Found a Guitar {item.Specs.Builder} - {item.Specs.Model} that you might like:");
                }
            }
            else
            {
                Console.WriteLine("No matching guitar found.");
            }

            ////////////////////////////////////////////////////

            Mandolin[] dataMandolin = new Mandolin[]
            {
                new Mandolin("123", 1000, new MandolinSpecs(BuilderEnum.Fender, "Stratocaster", TypeEnum.Electric, WoodEnum.Alder, WoodEnum.Alder, StyleEnum.A)),
                new Mandolin("124", 1500, new MandolinSpecs(BuilderEnum.Gibson, "Les Paul", TypeEnum.Electric, WoodEnum.Mahogany, WoodEnum.Maple, StyleEnum.F)),
                new Mandolin("125", 2000, new MandolinSpecs(BuilderEnum.Martin, "D-28", TypeEnum.Acoustic, WoodEnum.Rosewood, WoodEnum.Spruce, StyleEnum.A)),
                new Mandolin("126", 2500, new MandolinSpecs(BuilderEnum.Taylor, "814ce", TypeEnum.Acoustic, WoodEnum.Mahogany, WoodEnum.Spruce, StyleEnum.F)),
            };
            Inventory inventoryMandolin = new Inventory(dataMandolin);

            var Mandolin = new MandolinSpecs(null, "", null, null, null, StyleEnum.F);
            var resultMandolin = inventoryMandolin.search<Mandolin>(Mandolin);
            
            if (resultMandolin.Length > 0)
            {
                foreach (var item in resultMandolin)
                {
                      Console.WriteLine($"Found a Mandolin {item.Specs.Builder} - {item.Specs.Model} that you might like:");
                }
            }
            else
            {
                Console.WriteLine("No matching Mandolin found.");
            }

        }
    }
} 
