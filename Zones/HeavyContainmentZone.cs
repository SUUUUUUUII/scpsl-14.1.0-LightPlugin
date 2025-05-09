using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabApi.Features.Wrappers;
using MapGeneration;

namespace HCZ
{
    public class HeavyContainmentZone
    {
        public void HCZRed()
        {

            Map.SetColorOfLights(UnityEngine.Color.red,FacilityZone.HeavyContainment);

        }
        public void HCZBlue()
        {

            Map.SetColorOfLights(UnityEngine.Color.blue, FacilityZone.HeavyContainment);

        }
        public void HCZGreen()
        {

            Map.SetColorOfLights(UnityEngine.Color.green, FacilityZone.HeavyContainment);

        }
        public void HCZBlack()
        {

            Map.SetColorOfLights(UnityEngine.Color.black, FacilityZone.HeavyContainment);

        }
        public void HCZCyan()
        {

            Map.SetColorOfLights(UnityEngine.Color.cyan, FacilityZone.HeavyContainment);

        }
        public void HCZYellow()
        {

            Map.SetColorOfLights(UnityEngine.Color.yellow, FacilityZone.HeavyContainment);

        }
        public void HCZPurple()
        {

            Map.SetColorOfLights(UnityEngine.Color.magenta, FacilityZone.HeavyContainment);

        }
    }
}
