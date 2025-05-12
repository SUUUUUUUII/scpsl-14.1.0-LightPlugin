using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabApi.Features.Wrappers;
using MapGeneration;

namespace Surface
{
    public class SurfaceZone
    {
        public void SRed()
        {

            Map.SetColorOfLights(UnityEngine.Color.red,FacilityZone.Surface);

        }
        public void SBlue()
        {

            Map.SetColorOfLights(UnityEngine.Color.blue, FacilityZone.Surface);

        }
        public void SGreen()
        {

            Map.SetColorOfLights(UnityEngine.Color.green, FacilityZone.Surface);

        }
        public void SBlack()
        {

            Map.SetColorOfLights(UnityEngine.Color.black, FacilityZone.Surface);

        }
        public void SCyan()
        {

            Map.SetColorOfLights(UnityEngine.Color.cyan, FacilityZone.Surface);

        }
        public void SYellow()
        {

            Map.SetColorOfLights(UnityEngine.Color.yellow, FacilityZone.Surface);

        }
        public void SPurple()
        {

            Map.SetColorOfLights(UnityEngine.Color.magenta, FacilityZone.Surface);

        }
    }
}
