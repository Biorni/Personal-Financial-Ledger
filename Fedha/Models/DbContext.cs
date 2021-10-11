using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
namespace Fedha.Models
{
    //singelton acces to database
   public static class DbContext
    {
         static LiteDatabase _instance;

        public static void Init(string fileNme)
        {
            _instance = new LiteDatabase(fileNme);
        }

        public static LiteDatabase GetInstace()
        {
            return _instance;
        }
    }
}
