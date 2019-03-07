using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machines.Model;
using Machines.Interfaces;

namespace Machines
{
    public class LiteDbEntity<T> : ILiteDbEntity<T>
    {
        public LiteDbEntity(string DbName)
        {
            this.DbName = DbName;
        }

        public string DbName { get; private set; }        

        public void Add(T data)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.DbName))
                    throw new Exception("Строка подключения не должна быть пустой!");

                using (var db = new LiteDatabase(this.DbName))
                {
                    var collection = db.GetCollection<T>(typeof(T).Name);
                    collection.Insert(data);
                }
                Console.WriteLine("Запись добавлена!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //public void Delete(int id)
        //{
        //    try
        //    {
        //        if (string.IsNullOrWhiteSpace(this.DbName))
        //            throw new Exception("Строка подключения не должна быть пустой!");

        //        using (var db = new LiteDatabase(this.DbName))
        //        {
        //            var collection = db.GetCollection<T>(typeof(T).Name);
        //            collection.Delete(id);
        //        }
        //        Console.WriteLine("Запись удалена!");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        public void Edit(T data)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.DbName))
                    throw new Exception("Строка подключения не должна быть пустой!");

                using (var db = new LiteDatabase(this.DbName))
                {
                    var collection = db.GetCollection<T>(typeof(T).Name);
                    collection.Update(data);
                }
                Console.WriteLine("Запись изменена!");
            
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public List<T> GetCollection()
        {
            List<T> collection = null;
            try
            {
                if (string.IsNullOrWhiteSpace(this.DbName))
                    throw new Exception("Строка подключения не должна быть пустой!");

                using (var db = new LiteDatabase(this.DbName))
                {
                    collection = db.GetCollection<T>(typeof(T).Name).FindAll().ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return collection;
        }
    }
}
