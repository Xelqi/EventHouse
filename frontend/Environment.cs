using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend
{
    internal static class Environment
    {
        public static string GetBaseUrl()
        {
            return "http://localhost:5109/";
            //return "https://somecloud-server.com/";
        }
    }
}