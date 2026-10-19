using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Tan_OOPLab3.POS;


namespace Tan_OOPLab3
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            POSUI start = new POSUI();
            start.Login();
        }
    }
}
