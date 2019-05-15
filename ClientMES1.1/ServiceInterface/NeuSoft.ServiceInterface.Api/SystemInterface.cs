using NeuSofr.ServiceInterface.ImplementInterfaceAPI;
using NeuSoft.ServcieInterface.InterfaceAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.Api
{
    public class SystemInterface
    {
        private static IInterfaceFactory interfaceFactory;
        public static IInterfaceFactory CreateInterfaceIntances()
        {
            if (interfaceFactory == null)
            {
                interfaceFactory = new InterfaceFactory();
            }
            return interfaceFactory;
        }
    }
}
