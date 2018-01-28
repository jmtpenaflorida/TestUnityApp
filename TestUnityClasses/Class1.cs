using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestUnityCommon;

namespace TestUnityClasses
{
  
    public class SolidUnityClass : IUnityInterface
    {
        public string Get()
        {
            return "Solid";
        }
    }

    public class LiquidUnityClass : IUnityInterface
    {
        public string Get()
        {
            return "Liquid";
        }
    }
}
