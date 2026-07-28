using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Tan_OOPLab3.Models.BaseClass;


namespace Tan_OOPLab3.Methods
{
    public class MenuDisplayAction
    {
        //constructor gi kuha niya ang data ni MenuCreateAction unya gi pasa ni MenuDisplayAction
        private MenuCreateAction action;
        public MenuDisplayAction(MenuCreateAction action)
        {
            this.action = action;
        }
        //method use to display dog information
        public void DisplayDoginfo()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========================================");
            Console.WriteLine("          DOG INFORMATION");
            Console.WriteLine("========================================");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("--------------- Dog #1 ----------------");
            Console.WriteLine($"Name  : {action.dog1.Name}");
            Console.WriteLine($"Breed : {action.dog1.Breed}");
            Console.WriteLine($"Sex   : {action.dog1.Sex}");

            Console.WriteLine();
            Console.WriteLine("--------------- Dog #2 ----------------");
            Console.WriteLine($"Name  : {action.dog2.Name}");
            Console.WriteLine($"Breed : {action.dog2.Breed}");
            Console.WriteLine($"Sex   : {action.dog2.Sex}");

            Console.WriteLine();
            Console.WriteLine("--------------- Dog #3 ----------------");
            Console.WriteLine($"Name  : {action.dog3.Name}");
            Console.WriteLine($"Breed : {action.dog3.Breed}");
            Console.WriteLine($"Sex   : {action.dog3.Sex}");

            Console.WriteLine();
            Console.WriteLine("========================================");
        }
        //method use to diplay cat Information
        public void DisplayCatInfo()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("========================================");
            Console.WriteLine("          CAT INFORMATION");
            Console.WriteLine("========================================");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("--------------- Cat #1 ----------------");
            Console.WriteLine($"Name  : {action.cat1.Name}");
            Console.WriteLine($"Breed : {action.cat1.Breed}");
            Console.WriteLine($"Sex   : {action.cat1.Sex}");

            Console.WriteLine();
            Console.WriteLine("--------------- Cat #2 ----------------");
            Console.WriteLine($"Name  : {action.cat2.Name}");
            Console.WriteLine($"Breed : {action.cat2.Breed}");
            Console.WriteLine($"Sex   : {action.cat2.Sex}");

            Console.WriteLine();
            Console.WriteLine("--------------- Cat #3 ----------------");
            Console.WriteLine($"Name  : {action.cat3.Name}");
            Console.WriteLine($"Breed : {action.cat3.Breed}");
            Console.WriteLine($"Sex   : {action.cat3.Sex}");

            Console.WriteLine();
            Console.WriteLine("========================================");
        }
    }
}
