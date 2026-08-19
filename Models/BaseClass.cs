using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tan_OOPLab3.Models
{
    internal class BaseClass
    {
        // class
        private double width {get; set;}
        private double length {get; set;}
        private double perimeter {get; set;}

        //settters
        public double Width
        {
            get { return width; }
            set { if(value > 0)
                width = value;
                else
                    Console.WriteLine("Invalid");
            }
        }
        //settters
        public double Length
        {
            get { return length; }
            set {
                if (value > 0) length = value;
                else
                    Console.WriteLine("Invalid");
                    }
        }
        //settters
        public double Perimeter
        {
            get {
                return perimeter = (2 * length) + (2 * width); }
            set { perimeter = value; }
        }
        // get means get the data
        // setter means set the data
       

        

    }
}
