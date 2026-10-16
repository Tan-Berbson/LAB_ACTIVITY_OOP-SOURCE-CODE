using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tan_OOPLab3.Models
{
    public class POSUI : POS
    {
        // Login Method
        public void Login()
        {
            AccountUsername accountUsername = new AccountUsername();
            AccountPassword accountPassword = new AccountPassword();

            accountUsername.username = "admin";
            accountPassword.password = "admin123";

            const int boxWidth = 55;
            const int boxHeight = 12;

            while (true)
            {
                Console.Clear();

                string border = "+" + new string('=', boxWidth) + "+";

                int left = Math.Max(0,
                    (Console.WindowWidth - (boxWidth + 2)) / 2);

                int top = Math.Max(0,
                    (Console.WindowHeight - boxHeight) / 2);

                int row = top;

                void DrawRow(string text = "",
                    ConsoleColor color = ConsoleColor.Gray)
                {
                    Console.SetCursorPosition(left, row++);
                    Console.Write("|");

                    Console.ForegroundColor = color;
                    Console.Write(text.PadRight(boxWidth));
                    Console.ResetColor();

                    Console.WriteLine("|");
                }

                string CenterText(string text)
                {
                    int padding = Math.Max(0,
                        (boxWidth - text.Length) / 2);

                    return new string(' ', padding) + text;
                }

                void DrawStatus(string message, ConsoleColor color, int targetRow)
                {
                    int padding = Math.Max(0,
                        (boxWidth - message.Length) / 2);

                    Console.SetCursorPosition(left + 1, targetRow);
                    Console.Write(new string(' ', boxWidth));

                    Console.SetCursorPosition(left + 1 + padding, targetRow);
                    Console.ForegroundColor = color;
                    Console.Write(message);
                    Console.ResetColor();
                }

                // TOP BORDER
                Console.SetCursorPosition(left, row++);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(border);
                Console.ResetColor();

                // HEADER
                DrawRow();
                DrawRow(CenterText("POS MANAGEMENT SYSTEM"),
                    ConsoleColor.Cyan);

                DrawRow(CenterText("ADMINISTRATOR LOGIN"),
                    ConsoleColor.Yellow);

                DrawRow(new string('-', boxWidth),
                    ConsoleColor.DarkGray);

                DrawRow();

                // USERNAME
                int usernameRow = row;
                DrawRow("  Username:");

                DrawRow();

                // PASSWORD
                int passwordRow = row;
                DrawRow("  Password:");

                DrawRow();

                // STATUS ROW
                int statusRow = row;
                DrawRow();

                // BOTTOM BORDER
                Console.SetCursorPosition(left, row);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(border);
                Console.ResetColor();

                // USER INPUT
                Console.SetCursorPosition(
                    left + 1 + "  Username: ".Length,
                    usernameRow);

                string username = Console.ReadLine() ?? "";

                Console.SetCursorPosition(
                    left + 1 + "  Password: ".Length,
                    passwordRow);

                string password = ReadPassword();

                // VALIDATION
                if (username == accountUsername.username &&
                    password == accountPassword.password)
                {
                    DrawStatus("LOGIN SUCCESSFUL!",
                        ConsoleColor.Green, statusRow);

                    Console.ReadKey(true);
                    Dashboard();
                    return;
                }
                else
                {
                    DrawStatus("INVALID CREDENTIALS!",
                        ConsoleColor.Red, statusRow);

                    Console.ReadKey(true);
                }
            }
        }
        // Admin dashboard
        public void Dashboard()
        {
            int selectedIndex = 0;

            while (true)
            {
                Console.Clear();

                const int boxWidth = 75;
                string border = "+" + new string('=', boxWidth) + "+";

                int left = Math.Max(0, (Console.WindowWidth - (boxWidth + 2)) / 2);
                int top = Math.Max(0, (Console.WindowHeight - 22) / 2);
                int row = top;

                void DrawRow(string text, ConsoleColor color = ConsoleColor.Gray)
                {
                    Console.SetCursorPosition(left, row++);
                    Console.Write("|");

                    Console.ForegroundColor = color;
                    Console.Write(text.PadRight(boxWidth));
                    Console.ResetColor();

                    Console.WriteLine("|");
                }

                string CenterText(string text)
                {
                    int padding = Math.Max(0, (boxWidth - text.Length) / 2);
                    return new string(' ', padding) + text;
                }

                // TOP BORDER
                Console.SetCursorPosition(left, row++);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(border);
                Console.ResetColor();

                // HEADER
                DrawRow("");
                DrawRow(CenterText("POS MANAGEMENT SYSTEM"), ConsoleColor.Cyan);
                DrawRow(CenterText("POINT OF SALE AND INVENTORY"), ConsoleColor.Gray);
                DrawRow("");

                DrawRow(new string('=', boxWidth), ConsoleColor.DarkGray);

                DrawRow(CenterText("MAIN MENU"), ConsoleColor.Yellow);

                DrawRow(new string('-', boxWidth), ConsoleColor.DarkGray);
                DrawRow("");

                // NAVIGATION MENU
                DrawRow(
                    selectedIndex == 0
                        ? "      > [1] VIEW ALL PRODUCTS"
                        : "        [1] VIEW ALL PRODUCTS",
                    selectedIndex == 0 ? ConsoleColor.Green : ConsoleColor.Gray);

                DrawRow("");

                DrawRow(
                    selectedIndex == 1
                        ? "      > [2] EDIT PRODUCTS"
                        : "        [2] EDIT PRODUCTS",
                    selectedIndex == 1 ? ConsoleColor.Green : ConsoleColor.Gray);

                DrawRow("");

                DrawRow(
                    selectedIndex == 2
                        ? "      > [3] SELL PRODUCTS"
                        : "        [3] SELL PRODUCTS",
                    selectedIndex == 2 ? ConsoleColor.Green : ConsoleColor.Gray);

                DrawRow("");

                DrawRow(
                    selectedIndex == 3
                        ? "      > [4] LOG OUT"
                        : "        [4] LOG OUT",
                    selectedIndex == 3 ? ConsoleColor.Green : ConsoleColor.Gray);

                DrawRow("");

                // FOOTER
                DrawRow(new string('-', boxWidth), ConsoleColor.DarkGray);
                DrawRow(
                    CenterText("UP/DOWN: MOVE  |  ENTER: SELECT"),
                    ConsoleColor.Yellow);
                DrawRow("");

                // BOTTOM BORDER
                Console.SetCursorPosition(left, row);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(border);
                Console.ResetColor();

                // NAVIGATION
                ConsoleKey key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        selectedIndex = (selectedIndex - 1 + 4) % 4;
                        break;

                    case ConsoleKey.DownArrow:
                        selectedIndex = (selectedIndex + 1) % 4;
                        break;

                    case ConsoleKey.Enter:
                        switch (selectedIndex)
                        {
                            case 0:
                                // ViewAllProducts();
                                break;

                            case 1:
                                // EditProducts();
                                break;

                            case 2:
                                // SellProducts();
                                break;

                            case 3:
                                Login();
                                return;
                        }
                        break;
                }
            }
        }
        // password masking ******
        public static string ReadPassword()
        {
            // deri i store ang password
            string pass = "";
            // mga key imo pindoton
            ConsoleKeyInfo key;

            // loop keys while typing and end if the key is enter
            while ((key = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                // if ang key deli mag backspace mag print ng star 
                if (key.Key != ConsoleKey.Backspace)
                {
                    pass += key.KeyChar;
                    // Print a star for every letter typed
                    Console.Write("*");
                }
                // Handle Backspace 
                // if imo pindoton ang backspace ma remove ang pinka last nga letra
                else if (pass.Length > 0)
                {
                    pass = pass.Substring(0, pass.Length - 1);
                    //mao ni ang code para ma remove sad ang star
                    Console.Write("\b \b");
                }
            }
            Console.WriteLine();

            return pass;
        }
        // Centered message
        void ShowMessage(string message, ConsoleColor color)
        {
            int left = (Console.WindowWidth - message.Length) / 2;

            Console.SetCursorPosition(Math.Max(0, left), 12);
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
