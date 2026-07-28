using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tan_OOPLab3.Models;
using static Tan_OOPLab3.Models.BaseClass;

namespace Tan_OOPLab3.Methods
{
    public class MenuCreateAction
    {
        // dog class call
        public Dog dog1 = new Dog();
        public Dog dog2 = new Dog();
        public Dog dog3 = new Dog();

        //cat class call
        public Cat cat1 = new Cat();
        public Cat cat2 = new Cat();
        public Cat cat3 = new Cat();
        //method use to create dog information
        public void CreateDogInfo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========================================");
            Console.WriteLine("         CREATE DOG INFORMATION");
            Console.WriteLine("========================================");
            Console.ResetColor();

            Console.WriteLine("          Dog Information #1");
            Console.WriteLine("----------------------------------------");
            Console.Write("Name  : ");
            dog1.Name = Console.ReadLine();
            Console.Write("Breed : ");
            dog1.Breed = Console.ReadLine();
            Console.Write("Sex   : ");
            dog1.Sex = Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========================================");
            Console.WriteLine("         CREATE DOG INFORMATION");
            Console.WriteLine("========================================");
            Console.ResetColor();

            Console.WriteLine("         Dog Information #2");
            Console.WriteLine("----------------------------------------");
            Console.Write("Name  : ");
            dog2.Name = Console.ReadLine();
            Console.Write("Breed : ");
            dog2.Breed = Console.ReadLine();
            Console.Write("Sex   : ");
            dog2.Sex = Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========================================");
            Console.WriteLine("         CREATE DOG INFORMATION");
            Console.WriteLine("========================================");
            Console.ResetColor();

            Console.WriteLine("          Dog Information #3");
            Console.WriteLine("----------------------------------------");
            Console.Write("Name  : ");
            dog3.Name = Console.ReadLine();
            Console.Write("Breed : ");
            dog3.Breed = Console.ReadLine();
            Console.Write("Sex   : ");
            dog3.Sex = Console.ReadLine();
            Console.Clear();
        }
        //method use to create cat information
        public void CreateCatInfo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("========================================");
            Console.WriteLine("         CREATE CAT INFORMATION");
            Console.WriteLine("========================================");
            Console.ResetColor();

            Console.WriteLine("           Cat Information #1");
            Console.WriteLine("----------------------------------------");
            Console.Write("Name  : ");
            cat1.Name = Console.ReadLine();
            Console.Write("Breed : ");
            cat1.Breed = Console.ReadLine();
            Console.Write("Sex   : ");
            cat1.Sex = Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("========================================");
            Console.WriteLine("         CREATE CAT INFORMATION");
            Console.WriteLine("========================================");
            Console.ResetColor();

            Console.WriteLine("         Cat Information #2");
            Console.WriteLine("----------------------------------------");
            Console.Write("Name  : ");
            cat2.Name = Console.ReadLine();
            Console.Write("Breed : ");
            cat2.Breed = Console.ReadLine();
            Console.Write("Sex   : ");
            cat2.Sex = Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("========================================");
            Console.WriteLine("         CREATE CAT INFORMATION");
            Console.WriteLine("========================================");
            Console.ResetColor();

            Console.WriteLine("        Cat Information #3");
            Console.WriteLine("----------------------------------------");
            Console.Write("Name  : ");
            cat3.Name = Console.ReadLine();
            Console.Write("Breed : ");
            cat3.Breed = Console.ReadLine();
            Console.Write("Sex   : ");
            cat3.Sex = Console.ReadLine();
            Console.Clear();
        }
    }
}
