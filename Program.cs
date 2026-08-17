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
            BaseClass area = new BaseClass();
            Console.Write("Enter Width: ");
            area.Width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Lenghth: ");
            area.Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(area.Perimeter);

            
            
        }
    }
}
