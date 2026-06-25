using ch1.enums;

namespace ch1
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

            var guitar = new GuitarSpecs(null, "", TypeEnum.Electric, null, null, 0);
            var result = inventory.search(guitar);
            
            if (result.Length > 0)
            {
                foreach (var item in result)
                {
                      Console.WriteLine($"Found a {item.Specs.Builder} - {item.Specs.Model} that you might like:");
                }
            }
            else
            {
                Console.WriteLine("No matching guitar found.");
            }

        }
    }
} 
