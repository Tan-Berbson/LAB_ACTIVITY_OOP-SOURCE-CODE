using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tan_OOPLab3.Methods
{
    public class MainMenu
    {
        public void Menu()
        {
            //gikuha niya ang data ni menucrateaction , menudisplayaction ug selectDisplay
            MenuCreateAction action = new MenuCreateAction();
            MenuDisplayAction display = new MenuDisplayAction(action);
            SelectDisplay selectDisplay = new SelectDisplay(display);

            //loop until mo exit ang user
            while (true)
           {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("+======================================+");
                Console.WriteLine("|              DASHBOARD               |");
                Console.WriteLine("+======================================+");
                Console.ResetColor();

                Console.WriteLine("| [1] Create Dog Information           |");
                Console.WriteLine("| [2] Create Cat Information           |");
                Console.WriteLine("| [3] Display Information              |");
                Console.WriteLine("| [4] Exit                             |");
                Console.WriteLine("+======================================+");
                Console.Write("Select an option: ");

                Console.Write("Select: ");
                int select = Convert.ToInt32(Console.ReadLine());
                switch(select)
                {
                    case 1:
                        action.CreateDogInfo();
                        break;
                    case 2:
                        action.CreateCatInfo();
                        break;
                    case 3:
                        Console.Clear();
                        selectDisplay.SelectWhichToDisplay();
                        
                        break;
                    case 4:                      
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Select");
                        Console.ReadKey();
                        Console.ResetColor();
                        break;                     
                }
            }

           
        }
    }
}
