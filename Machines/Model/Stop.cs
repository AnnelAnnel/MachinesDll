using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machines.Model
{
    public class Stop
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public Car car { get; set; }
        public string description { get; set; }
        public string recommendation { get; set; }
        public Worker worker { get; set; }

        
        
        public Stop()
        {
            date = DateTime.Now;
        }

        public Stop(Car car, string description, string recommendation, Worker worker)
        {
            date = DateTime.Now;
            this.description = description;
            this.car = car;
            this.worker = worker;
        }

        public void printInfo()
        {
            Console.WriteLine("Дата поломки: {0:dd.MM.yyyy}", date);
            Console.WriteLine("Машина:");
            car.printInfo();
            Console.WriteLine("Описание: {0}", description);
            Console.WriteLine("Реккомендация: {0}", recommendation);
            Console.WriteLine("Работник:");
            worker.printInfo();
        }

        
    }
}
