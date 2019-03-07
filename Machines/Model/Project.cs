using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machines.Model
{
    public class Project
    {
        public int Id { get; set; }
        public string name { get; set; }

        public List<Car> cars = new List<Car>();

        public Project()
        {

        }
        public Project(string name)
        {
            this.name = name;
        }

        public void addCar(Car c)
        {         
            cars.Add(c);
        }

        public void printAll()
        {
            int k = 1;

            foreach (Car car in cars)
            {
                Console.Write("{0}.", k++);
                car.printInfo();
            }
        }
        public void printInfo()
        {
            Console.WriteLine("Название проекта: {0}", name);
            Console.WriteLine("Машин: {0}", cars.Count);
            printAll();
        }

        
        //2. Поиск машины по модели;
        public List<Car> findByModel(string model)
        {
            List<Car> found1 = cars.Where(c => c.model == model).ToList();
            return found1;
        }

        //2. Поиск машины по его гаражному номеру;
        public Car findByNumber(string garageNumber)
        {
            Car found2 = (Car)cars.Where(c => c.garageNumber == garageNumber);
            return found2;
        }
        //3. Из результатов поиска должна быть возможность, 
        //   создать останов для машины;

        public void showActive()
        {
            foreach (Car item in cars)
            {            
                if (item.status == status.active)
                    item.printInfo();
            }
        }

        public static Stop createStop(Car car, Worker worker)
        {
            Console.WriteLine("Введите описание проблемы:");
            string description = Console.ReadLine();
            Console.WriteLine("Введите рекоммендации:");
            string recommendation = Console.ReadLine();
            Stop stop = new Stop(car, description, recommendation, worker);
            return stop;
        }

        public bool createStop(Car car, Stop stop, out string message)
        {
            try
            {
                if (stop != null)
                {
                    if (car.status == status.active)
                    {
                        car.stops.Add(stop);
                        message = "Остановка добавлена";
                        return true;
                    }
                    else
                    {
                        message = "Данная машина неактивна";
                        return false;
                    }
                }
                else
                {
                    message = "Остановки не существует!";
                    return false;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }
        //4. Для любой машины должна быть возможность прикрепить компонент,
        //   при условии, что у данной машину уже не стоит данный компонент, 
        //   в случае если он стоит выдать соответствующее сообщение;
        public bool addComponent(Component component, Car car, out string message)
        {
            try
            {
                if (!(car.components.Contains(component)))
                {
                    car.components.Add(component);
                    message = "Компонент добавлен";
                    return true;
                }
                else
                {
                    message = "Такой компонент уже установлен!";
                    return false;
                }

            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public bool addNewComponent(Car car, out string message)
        {
            Console.WriteLine("Введите наименование компонента:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите код компонента:");
            string code = Console.ReadLine();
            Component comp = new Component(name, code);

            if (addComponent(comp, car, out message))
            {
                return true;
            }
            else
                return false;
        }               
      
    }
}
