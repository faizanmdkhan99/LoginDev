using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDev
{
    public class Program
    {
        public bool CheckDetails(string username,string password)
    {
        if(username.Equals("admin")&& password.Equals("pass123"))
        {
            return true;

        }
        else
        {
            return false;
        }
    }
    
        static void Main(string[] args)
        {
        }
    }
}
