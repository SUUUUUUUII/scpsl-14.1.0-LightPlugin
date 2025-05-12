using System;
using CommandSystem;
using LabApi.Features.Wrappers;
using MapGeneration;
using UnityEngine;

namespace FacilityColorLighting
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class ColorLighting : ICommand
    {

        public facility.Facility facility = new facility.Facility();

        public Surface.SurfaceZone surfaceclr = new Surface.SurfaceZone();

        public LCZ.LightContainmentZone lightclr = new LCZ.LightContainmentZone();

        public HCZ.HeavyContainmentZone heavyclr = new HCZ.HeavyContainmentZone();

        public EZ.EntranceZone entranceclr = new EZ.EntranceZone();
        public string Command => "light";
        public string[] Aliases => new[] { "changelights" }; 
        public string Description => "Change light color <color=yellow> { Reset } { ZoneType } { Color }";
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {

            if (sender.CheckPermission(PlayerPermissions.PlayersManagement))
            {

                response = "You have don't permission for use this command!";

            }
            if (arguments.Count == 0)
            {

                response = "Set color value foreach zone (ZoneType) (ColorType)";

                return false;

            }
            if (arguments.Count > 2)
            {
                response = "Value can't more one";
                return false;
            }
            //--FACILITY--

            if (arguments.At(0) == "red")
            {

                response = $"Change facility color on <color=red> Red!";

                facility.Red();

                return true;

            }
            if (arguments.At(0) == "blue")
            {

                response = $"Change facility color on <color=blue> Blue!";

                facility.Blue();

                return true;

            }
            if (arguments.At(0) == "green")
            {

                response = $"Change facility color on <color=green> Green!";

                facility.Green();

                return true;

            }
            if (arguments.At(0) == "black")
            {

                response = $"Change facility color on <color=black> Black!";

                facility.Black();

                return true;

            }
            if (arguments.At(0) == "purple")
            {

                response = $"Change facility color on <color=purple> Purple!";

                facility.Purple();

                return true;

            }
            if (arguments.At(0) == "yellow")
            {

                response = $"Change facility color on <color=yellow> Yellow!";

                facility.Yellow();

                return true;

            }
            if (arguments.At(0) == "cyan")
            {

                response = $"Change facility color on <color=blue> Cyan!";

                facility.Cyan();

                return true;

            }

            //--------------------------------------------------------------

            //--SURFACE--

            if (arguments.At(0) == "surface" && arguments.At(1) == "red")
            {

                response = $"Change surface zone color on <color=red> Red!";

                surfaceclr.SRed();

                return true;

            }
            if (arguments.At(0) == "surface" && arguments.At(1) == "blue")
            {

                response = $"Change surface zone color on <color=blue> Blue!";

                surfaceclr.SBlue();

                return true;

            }
            if (arguments.At(0) == "surface" && arguments.At(1) == "green")
            {

                response = $"Change surface zone color on <color=green> Green!";

                surfaceclr.SGreen();

                return true;

            }
            if (arguments.At(0) == "surface" && arguments.At(1) == "black")
            {

                response = $"Change surface zone color on <color=black> Black!";

                surfaceclr.SBlack(); ;

                return true;

            }
            if (arguments.At(0) == "surface" && arguments.At(1) == "purple")
            {

                response = $"Change surface zone color on <color=purple> Purple!";

                surfaceclr.SPurple();

                return true;

            }
            if (arguments.At(0) == "surface" && arguments.At(1) == "yellow")
            {

                response = $"Change surface zone color on <color=yellow> Yellow!";

                surfaceclr.SYellow();

                return true;

            }
            if (arguments.At(0) == "surface" && arguments.At(1) == "cyan")
            {

                response = $"Change surface zone color on <color=blue> Cyan!";

                surfaceclr.SCyan();

                return true;

            }
            //--LIGHT CONTAINMENT ZONE--

            if (arguments.At(0) == "lcz" && arguments.At(1) == "red")
            {

                response = $"Change {FacilityZone.LightContainment} zone color on <color=red> Red!";

                lightclr.LCZRed();

                return true;

            }
            if (arguments.At(0) == "lcz" && arguments.At(1) == "blue")
            {

                response = $"Change {FacilityZone.LightContainment} zone color on <color=blue> Blue!";

                lightclr.LCZBlue();

                return true;

            }
            if (arguments.At(0) == "lcz" && arguments.At(1) == "green")
            {

                response = $"Change {FacilityZone.LightContainment} zone color on <color=green> Green!";

                lightclr.LCZGreen();

                return true;

            }
            if (arguments.At(0) == "lcz" && arguments.At(1) == "black")
            {

                response = $"Change {FacilityZone.LightContainment} zone color on <color=black> Black!";

                lightclr.LCZBlack();

                return true;

            }
            if (arguments.At(0) == "lcz" && arguments.At(1) == "purple")
            {

                response = $"Change {FacilityZone.LightContainment} zone color on <color=purple> Purple!";

                lightclr.LCZPurple();

                return true;

            }
            if (arguments.At(0) == "lcz" && arguments.At(1) == "yellow")
            {

                response = $"Change {FacilityZone.LightContainment} zone color on <color=yellow> Yellow!";

                lightclr.LCZYellow();

                return true;

            }
            if (arguments.At(0) == "lcz" && arguments.At(1) == "cyan")
            {

                response = $"Change {FacilityZone.LightContainment} zone color on <color=blue> Cyan!";

                lightclr.LCZCyan();

                return true;

            }

            //--------------------------------------------------------------

            //--HEAVY CONTAINMENT ZONE--

            if (arguments.At(0) == "hcz" && arguments.At(1) == "red")
            {

                response = $"Change zone {FacilityZone.HeavyContainment} zone color on <color=red> Red!";

                heavyclr.HCZRed();

                return true;

            }
            if (arguments.At(0) == "hcz" && arguments.At(1) == "blue")
            {

                response = $"Change {FacilityZone.HeavyContainment} zone color on <color=blue> Blue!";

                heavyclr.HCZBlue();

                return true;

            }
            if (arguments.At(0) == "hcz" && arguments.At(1) == "green")
            {

                response = $"Change {FacilityZone.HeavyContainment} zone color on <color=green> Green!";

                heavyclr.HCZGreen();

                return true;

            }
            if (arguments.At(0) == "hcz" && arguments.At(1) == "black")
            {

                response = $"Change {FacilityZone.HeavyContainment} zone color on <color=black> Black!";

                heavyclr.HCZBlack();

                return true;

            }
            if (arguments.At(0) == "hcz" && arguments.At(1) == "purple")
            {

                response = $"Change {FacilityZone.HeavyContainment} zone color on <color=purple> Purple!";

                heavyclr.HCZPurple();

                return true;

            }
            if (arguments.At(0) == "hcz" && arguments.At(1) == "yellow")
            {

                response = $"Change {FacilityZone.HeavyContainment} zone color on <color=yellow> Yellow!";

                heavyclr.HCZYellow();

                return true;

            }
            if (arguments.At(0) == "hcz" && arguments.At(1) == "cyan")
            {

                response = $"Change {FacilityZone.HeavyContainment} zone color on <color=blue> Cyan!";

                heavyclr.HCZCyan();

                return true;

            }

            //--------------------------------------------------------------

            //--ENTRANCE ZONE--

            if (arguments.At(0) == "ez" && arguments.At(1) == "red")
            {

                response = $"Change {FacilityZone.Entrance} zone color on <color=red> Red!";

                entranceclr.EZRed();

                return true;

            }
            if (arguments.At(0) == "ez" && arguments.At(1) == "blue")
            {

                response = $"Change {FacilityZone.Entrance} zone color on <color=blue> Blue!";

                entranceclr.EZBlue();

                return true;

            }
            if (arguments.At(0) == "ez" && arguments.At(1) == "green")
            {

                response = $"Change {FacilityZone.Entrance} zone color on <color=green> Green!";

                entranceclr.EZGreen();

                return true;

            }
            if (arguments.At(0) == "ez" && arguments.At(1) == "black")
            {

                response = $"Change {FacilityZone.Entrance} zone color on <color=black> Black!";

                entranceclr.EZBlack();

                return true;

            }
            if (arguments.At(0) == "ez" && arguments.At(1) == "purple")
            {

                response = $"Change {FacilityZone.Entrance} zone color on <color=purple> Purple!";

                entranceclr.EZPurple(); ;

                return true;

            }
            if (arguments.At(0) == "ez" && arguments.At(1) == "yellow")
            {

                response = $"Change {FacilityZone.Entrance} zone color on <color=yellow> Yellow!";

                entranceclr.EZYellow();

                return true;

            }
            if (arguments.At(0) == "ez" && arguments.At(1) == "cyan")
            {

                response = $"Change {FacilityZone.Entrance} zone color on <color=blue> Cyan!";

                entranceclr.EZCyan();

                return true;

            }

            //--------------------------------------------------------------

            if (arguments.At(0) == "reset")
            {

                response = "Color light's of facility now reset";

                Map.SetColorOfLights(Color.clear);

                return true;

            }
            response = "Arguments must be correct \n and these should without big letters";
            return false;
        }
    }
}
