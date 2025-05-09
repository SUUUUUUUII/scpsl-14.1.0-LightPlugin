using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabApi.Features.Wrappers;
using MapGeneration;

namespace LCZ
{
    public class LightContainmentZone
    {
        public void LCZRed()
        {

            Map.SetColorOfLights(UnityEngine.Color.red,FacilityZone.LightContainment);

        }
        public void LCZBlue()
        {

            Map.SetColorOfLights(UnityEngine.Color.blue, FacilityZone.LightContainment);

        }
        public void LCZGreen()
        {

            Map.SetColorOfLights(UnityEngine.Color.green, FacilityZone.LightContainment);

        }
        public void LCZBlack()
        {

            Map.SetColorOfLights(UnityEngine.Color.black, FacilityZone.LightContainment);

        }
        public void LCZCyan()
        {

            Map.SetColorOfLights(UnityEngine.Color.cyan, FacilityZone.LightContainment);

        }
        public void LCZYellow()
        {

            Map.SetColorOfLights(UnityEngine.Color.yellow, FacilityZone.LightContainment);

        }
        public void LCZPurple()
        {

            Map.SetColorOfLights(UnityEngine.Color.magenta, FacilityZone.LightContainment);

        }
    }
}
