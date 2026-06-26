using ch5_p1.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_p1
{
    public abstract class InstrumentSpecs
    {
        public BuilderEnum? Builder { get; set; }
        public string Model { get; set; }
        public TypeEnum? Type { get; set; }
        public WoodEnum? BackWood { get; set; }
        public WoodEnum? TopWood { get; set; }

        public InstrumentSpecs(
      BuilderEnum? builder,
      string model,
      TypeEnum? type,
      WoodEnum? backWood,
      WoodEnum? topWood)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
        }

        public virtual bool equals(InstrumentSpecs specs)
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
            return true;
        }
    }
}
