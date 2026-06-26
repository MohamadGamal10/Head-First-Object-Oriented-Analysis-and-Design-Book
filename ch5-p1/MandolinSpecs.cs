using ch5_p1.enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_p1
{
    public class MandolinSpecs : InstrumentSpecs
    {
        private StyleEnum? Style { get; set; }

        public MandolinSpecs(
      BuilderEnum? builder,
      string model,
      TypeEnum? type,
      WoodEnum? backWood,
      WoodEnum? topWood,
            StyleEnum? style
) : base(builder, model, type, backWood, topWood)
        {
            Style = style;
        }

        public override bool equals(InstrumentSpecs specs)
        {
            if (!base.equals(specs))
                return false;

            if (specs is not MandolinSpecs mandolinSpecs)
                return false;

            if (mandolinSpecs.Style != null && mandolinSpecs.Style != Style)
                return false;

            return true;
        }
    }
}
