using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machines.Model
{
    public class Project : ServiceCar
    {
        public int Id { get; set; }
        public string name { get; set; }

        public Project()
        {

        }
        public Project(string name) : base()
        {
            this.name = name;
        }
         
            
    

        //public void addCar(Car c)
        //{
        //    cars.Add(c);
        //}

        //public void printAll()
        //{
        //    int k = 1;

        //    foreach (Car car in cars)
        //    {
        //        Console.Write("{0}.", k++);
        //        car.printInfo();
        //    }
        //}
        public void printInfo()
        {
            Console.WriteLine("Название проекта: {0}", name);
            Console.WriteLine("Машин: {0}", cars.Count);
            printAll();  
            
        }

    }
}
