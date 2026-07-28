using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tan_OOPLab3.Methods;
using Tan_OOPLab3.Models;

namespace Tan_OOPLab3.Methods
{
    public class SelectDisplay
    {
        //constructor code from menudisplay data to select display
        // gi kuha ang menudisplayaction data gi pasa sa selectdisplay
        private MenuDisplayAction action;
        public SelectDisplay(MenuDisplayAction action)
        {
            this.action = action;
        }
        public void SelectWhichToDisplay()
        {
            //loop until the user go to dashboard
            bool back = true;
            while (back)
            {    
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("========================================");
                Console.WriteLine("           DISPLAY INFORMATION");
                Console.WriteLine("========================================");
                Console.ResetColor();
                Console.WriteLine(" [1] Dog Information");
                Console.WriteLine(" [2] Cat Information");
                Console.WriteLine(" [3] Dashboard");
                Console.WriteLine("----------------------------------------");
                Console.Write(" Select an option: ");
                int select = Convert.ToInt32(Console.ReadLine());
                
                //user select which to display
                switch (select)
                {
                    case 1:
                        Console.Clear();
                        action.DisplayDoginfo();
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 2:
                        Console.Clear();
                        action.DisplayCatInfo();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                        
                    case 3:
                        //back to dashboard
                        back = false;
                        Console.Clear();
                        break;
                }
            }

        }
    }
}
