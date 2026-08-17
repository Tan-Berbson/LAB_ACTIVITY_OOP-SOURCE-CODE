using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tan_OOPLab3.Methods; 

namespace Tan_OOPLab3
{
    internal class Program
    {
      
        static void Main(string[] args)
        {   // ang main menu class ako gitawag gamit ang method na Menu para ma display ang menu dashboard
            // ang purpose nganong wala nako gi code deri sa program.cs  ang mga logic sa app gusto nako organize ug maintainable  akong code para dali ra matrace kung asa dapit ang error ug ma fix dayun
            MainMenu Menumethods = new MainMenu();
            Menumethods.Menu();
            //Methods Folder
            // Mainmenu mao na ang dashboard 
            // MenuCreateDisplayAction Mao na nga method gamiton para mag create ug data
            // MenuDisplayAction Mao na nga method gamiton para sa output sa data
            // SelectDisplay mao na nga method gamiton para sa pag select kung unsa nga data nga i display

            // Models
            // BaseClass mao na class ako gigamit sa entire app
        }
    }
}
