using ch1.enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    public class GuitarSpecs
    {
        public BuilderEnum? Builder { get; set; }
        public string Model { get; set; }
        public TypeEnum? Type { get; set; }
        public WoodEnum? BackWood { get; set; }
        public WoodEnum? TopWood { get; set; }
        public int NumStrings { get; set; }

        public GuitarSpecs(
      BuilderEnum? builder,
      string model,
      TypeEnum? type,
      WoodEnum? backWood,
      WoodEnum? topWood,
            int numStrings)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
            NumStrings = numStrings;
        }

        public bool equals(GuitarSpecs specs)
        {
            if (specs.Builder != null && specs.Builder != Builder)
                return false;
            if (specs.Model != null && specs.Model != "" && specs.Model.ToLower() != Model.ToLower())
                return false;
            if (specs.Type != null && specs.Type != Type)
                return false;
            if (specs.BackWood != null && specs.BackWood != BackWood)
                return false;
            if (specs.TopWood != null && specs.TopWood != TopWood)
                return false;
            if (specs.TopWood != null && specs.NumStrings != NumStrings)
                return false;
            return true;
        } 
    }
}
