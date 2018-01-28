using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestUnityClasses;
using TestUnityCommon;

namespace TestUnityConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer myContainer = new UnityContainer();
            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            section.Containers["containerOne"].Configure(myContainer);

            Console.WriteLine(myContainer.Resolve<IUnityInterface>().Get());

            Console.ReadLine();

        }
    }

   
}
