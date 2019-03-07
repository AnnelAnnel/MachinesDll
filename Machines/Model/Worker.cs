using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machines.Model
{
    public enum access { менеджер, работник }
    public class Worker
    {
        public int Id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public access access { get; set; }
        public Project project { get; set; }

        public Worker()
        {
            
        }

        public Worker(string login, string password, access access)
        {
            this.login = login;
            this.password = password;
            this.access = access;
            this.project = null;
            
        }
        //2. Должна быть возможность создать пользователя
        public Worker createWorker()
        {
            Worker worker = new Worker();
            Console.WriteLine("Введите логин: ");
            worker.login = Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            worker.password = Console.ReadLine();
            Console.WriteLine("Укажите позицию: 1- менеджер, 2- работник");

            int choice = 0;
            bool test = Int32.TryParse(Console.ReadLine(), out choice);
            if (test == false || choice > 2 || choice < 1)
            {
                while (test == false)
                {
                    Console.WriteLine("Неверно введены данные. Попробуйте еще раз:");
                    test = Int32.TryParse(Console.ReadLine(), out choice);
                }
            }
            if (choice == 1)
                worker.access = access.менеджер;
            if (choice == 2)
                worker.access = access.работник;
            else
                worker.access = access.работник; //default
            worker.project = null;
            Console.WriteLine("Работник создан");
            return worker;
        }

        public void printInfo()
        {
            Console.WriteLine("Позиция: {0}", access);
            Console.WriteLine("Логин: {0}", login);

            if (project != null)
            {
                Console.WriteLine("Проект: {0}", project.name);
                               
            }
        }
    }
}
