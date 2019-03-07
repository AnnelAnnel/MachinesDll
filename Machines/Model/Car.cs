using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machines.Model
{
    public enum type { дробилка, погрузчик, самосвал }
    public enum status { active, inactive }
  

    public class Car
    {
        public Car()
        {

        }
        public Car(string brand, string model,string garageNumber, type type)
        {

            this.brand = brand;
            this.model = model;
            this.productionYear = DateTime.Now.AddYears(rnd.Next(1, 10));
            this.garageNumber = garageNumber;
            this.type = type;
            this.status = status.inactive;
            List<Component> components = new List<Component>();
            List<Stop> stops = new List<Stop>();

        }
        public int Id { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public DateTime productionYear { get; set; }
        public string garageNumber { get; set; }
        public type type { get; set; }
        public status status { get; set; }
        public List<Component> components { get; set; }
        public List<Stop> stops { get; set; }
        private static Random rnd = new Random();

        public void printInfo()
        {
            Console.WriteLine("Марка: {0}", brand);
            Console.WriteLine("Модель: {0}", model);
            Console.WriteLine("Тип: {0}", type);
            Console.WriteLine("Номер гаража: {0}", garageNumber);
            Console.WriteLine("Дата производства: {0}", productionYear);
            if (status == status.active)
                Console.ForegroundColor = ConsoleColor.Green;
            if (status == status.inactive)
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Статус: {0}", status);
            Console.ForegroundColor = ConsoleColor.White;
            int k = 1;

            if (components != null)
            {
                Console.WriteLine("Список компонентов:");
                foreach (Component item in components)
                {
                    Console.Write("{0}. {1}", k++, item);
                }
                k = 1;
            }
            if (stops != null)
            {
                Console.WriteLine("Остановки:");
                foreach (Stop item2 in stops)
                {
                    Console.Write("{0}. {1}", k++, item2);
                }
            }
            Console.WriteLine();
        }

    }

}
