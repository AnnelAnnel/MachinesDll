using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Machines.Model
{
    
    public struct Component
    {      
        public Component(string name, string code)
        {           
            this.name = name;
            this.code = code;
        }

        
        public string name { get; set; }
        public string code { get; set; }

        public void printInfo()
        {
            Console.WriteLine("Наименование: {0}\nКод: {1}", name, code);
        }
    }
}
