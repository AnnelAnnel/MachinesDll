using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Machines.Interfaces
{
    interface ILiteDbEntity<T>
    {
        string DbName { get; }        

        void Add(T data);
        void Edit(T data);
        //void Delete(int id);
        List<T> GetCollection();
    }
}
