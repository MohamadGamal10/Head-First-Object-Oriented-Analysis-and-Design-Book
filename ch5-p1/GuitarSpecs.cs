using ch5_p1.enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_p1
{
    public class GuitarSpecs : InstrumentSpecs
    {
        public int NumStrings { get; set; }

        public GuitarSpecs(
              BuilderEnum? builder,
              string model,
              TypeEnum? type,
              WoodEnum? backWood,
              WoodEnum? topWood,
              int numStrings
        ) : base(builder, model, type, backWood, topWood)
        {
            NumStrings = numStrings;
        }

        public override bool equals(InstrumentSpecs specs)
        {
            if (!base.equals(specs))
                return false;

            if(specs is not GuitarSpecs guitarSpecs)
                return false;

            if (guitarSpecs.NumStrings != NumStrings)
                return false;

            return true;
        }
    }
}
