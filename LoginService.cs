using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CommonClass
{
   public class LoginService
    {
        public  void WriteToFile(ILoggable obj)
        {
            Console.WriteLine(obj.Log());
        }
    }
}
