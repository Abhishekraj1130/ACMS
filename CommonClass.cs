using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CommonClass
{
    public static class CommonClass
    {
        public static string GetFormated(this String val)
        {
            return val.Replace(",", " ");
        }
    }
}
