using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machines.Model

{
    public class ServiceComponent
    {       

        List<Component> components = new List<Component>();

        

        //1. Отобразить все компоненты на проекте
        public void printAll()
        {
            int k = 1;
            foreach (Component component in components)
            {
                Console.Write("{0}.", k++);
                component.printInfo();
            }
        }       
    }
}
