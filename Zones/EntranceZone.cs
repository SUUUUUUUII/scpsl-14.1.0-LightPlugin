using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabApi.Features.Wrappers;
using MapGeneration;

namespace EZ
{
    public class EntranceZone
    {
        public void EZRed()
        {

            Map.SetColorOfLights(UnityEngine.Color.red,FacilityZone.Entrance);

        }
        public void EZBlue()
        {

            Map.SetColorOfLights(UnityEngine.Color.blue, FacilityZone.Entrance);

        }
        public void EZGreen()
        {

            Map.SetColorOfLights(UnityEngine.Color.green, FacilityZone.Entrance);

        }
        public void EZBlack()
        {

            Map.SetColorOfLights(UnityEngine.Color.black, FacilityZone.Entrance);

        }
        public void EZCyan()
        {

            Map.SetColorOfLights(UnityEngine.Color.cyan, FacilityZone.Entrance);

        }
        public void EZYellow()
        {

            Map.SetColorOfLights(UnityEngine.Color.yellow, FacilityZone.Entrance);

        }
        public void EZPurple()
        {

            Map.SetColorOfLights(UnityEngine.Color.magenta, FacilityZone.Entrance);

        }
    }
}
