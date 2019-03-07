using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Machines
{
    public class Service<T> : LiteDbEntity<T>
    {
        public Service(string DbName) : base(DbName) { }


    }
}