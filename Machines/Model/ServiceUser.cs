
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Machines.Model
{
    public class ServiceUser
    {
        //public bool Registration(User user, out string message)
        //{
        //    try
        //    {
        //        using (LiteDatabase db = new LiteDatabase("KKB.db"))
        //        {
        //            var users = db.GetCollection<User>("User");
        //            users.Insert(user);
        //        }
        //        message = "Registraion completed successfully";
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        message = ex.Message;
        //        return false;
        //    }

        //}

        //public List<Worker> users = new List<Worker>();




        //public void addWorker(out string message)
        //{
        //    using (FileStream fileStream = new FileStream("Workers.csv", FileMode.OpenOrCreate))
        //    {
        //        using (StreamWriter streamWriter = new StreamWriter(fileStream))
        //        {
        //            Worker user = new Worker();
        //            Console.WriteLine("Введите логин: ");
        //            user.login = Console.ReadLine();
        //            Console.WriteLine("Введите пароль: ");
        //            user.password = Console.ReadLine();
        //            Console.WriteLine("Укажите позицию: 1- менеджер, 2- работник");

        //            int choice = 0;
        //            bool test = Int32.TryParse(Console.ReadLine(), out choice);
        //            if (test == false || choice > 2 || choice < 1)
        //            {
        //                while (test == false)
        //                {
        //                    Console.WriteLine("Неверно введены данные. Попробуйте еще раз:");
        //                    test = Int32.TryParse(Console.ReadLine(), out choice);
        //                }
        //            }
        //            if (choice == 1)
        //                user.access = access.менеджер;
        //            if (choice == 2)
        //                user.access = access.работник;
        //            else
        //                user.access = access.работник; //default

        //            string str = string.Format("{0};{1};{2};{3}",
        //                    user.login,
        //                    user.password,
        //                    user.access,
        //                    user.projects);
        //            streamWriter.WriteLine(str);

        //        }
        //    } 

        //        message = "Работник был добавлен";                
        //}

        //public List<Worker> getWorkers()
        //{
        //    List<Worker> workers = new List<Worker>();

        //    using (StreamReader sr = new StreamReader("Workers.csv"))
        //    {
        //        string line = "";
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            string[] data = line.Split(';');
        //            Worker worker = new Worker();
        //            worker.login=             

        //            workers.Add(worker);
        //        }
        //    }

        //    return workers;
        //}

        //1. Отобразить весь список пользователей по проектам

        //public void showUsersByProject(string projectName)
        //{
        //    using (LiteDatabase db = new LiteDatabase("Machines"))
        //    {
        //        var users = db.GetCollection<IUser<T>>("Users").FindAll();
        //        var tmp = users.Where(u => u.project.ToString() == projectName).ToList();
        //        foreach (var item in tmp)
        //        {
        //            item.printInfo();
        //        }

        //    }
        //}

        //public void showAllUsers()
        //{
        //    using (LiteDatabase db = new LiteDatabase("Machines"))
        //    {
        //        var users = db.GetCollection<IUser<T>>("Users").FindAll();
        //        foreach (var item in users)
        //        {
        //            item.printInfo();
        //        }

        //    }
        //}


    }

}

