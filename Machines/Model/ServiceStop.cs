using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machines.Model
{
    public class ServiceStop
    { 
        List<Stop> stops = new List<Stop>();

        //1. Отобразить весь список остановов;
        public void printInfo()
        {
            foreach (var item in stops)
            {
                item.printInfo();
            }
        }

        //2. Должна быть возможность создать останов для доступной машины.
        //Если у машины стоит запрет на создание,
        //то данная машина не должна отображаться в списке на создание останова;

       

    }
}
