using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabApi.Events;
using LabApi.Features;
using LabApi.Loader.Features.Plugins;

namespace FacilityClrLoader
{
    public class Lights : Plugin
    {
        public override string Name => "FacilitColorLights";

        public override string Description => "You can change light color foreach zone";

        public override string Author => "Me";

        public override Version Version => new Version(1, 4);

        public override Version RequiredApiVersion => new Version(1, 3);

        public override void Disable()
        {

        }

        public override void Enable()
        {
 
        }
    }
}
