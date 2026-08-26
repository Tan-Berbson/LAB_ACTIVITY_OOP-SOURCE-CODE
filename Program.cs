using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tan_OOPLab3.Models;

namespace Tan_OOPLab3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            ProductManager manager = new ProductManager();

            manager.Dashboard();
        }
    }
}
