using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sql =new SqlServer();
            sql.Add();
            MysqlServer mys=new MysqlServer();
            mys.Add();
            
            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Aded by deafult");    
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by deafult");
        }
    }

    class SqlServer:Database
    {

    }
    class MysqlServer : Database
    {

    }

}
