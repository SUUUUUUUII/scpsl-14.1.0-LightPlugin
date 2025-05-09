using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabApi.Features.Wrappers;
using MapGeneration;

namespace facility
{
    public class Facility
    {
        public void Red()
        {

            Map.SetColorOfLights(UnityEngine.Color.red);

        }
        public void Blue()
        {

            Map.SetColorOfLights(UnityEngine.Color.blue);

        }
        public void Green()
        {

            Map.SetColorOfLights(UnityEngine.Color.green);

        }
        public void Black()
        {

            Map.SetColorOfLights(UnityEngine.Color.black);

        }
        public void Cyan()
        {

            Map.SetColorOfLights(UnityEngine.Color.cyan);

        }
        public void Yellow()
        {

            Map.SetColorOfLights(UnityEngine.Color.yellow);

        }
        public void Purple()
        {

            Map.SetColorOfLights(UnityEngine.Color.magenta);

        }
    }
}
