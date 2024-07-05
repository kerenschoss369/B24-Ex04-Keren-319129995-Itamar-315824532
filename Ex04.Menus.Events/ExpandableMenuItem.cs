using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public class ExpandableMenuItem : MenuItem
    {
        private List<MenuItem> m_MenuItems;
        public ExpandableMenuItem(string i_Title) : base(i_Title)
        {
            m_MenuItems = new List<MenuItem>();
        }
        public override void HandleSelectedItem()
        {
            OnChosen();
        }
        public void AddMenuItem(MenuItem i_MenuItem)
        {
            m_MenuItems?.Add(i_MenuItem);
        }
        public void show()//maybe returns menuitem then handle it in events menu?
        {
            bool ExitOrBack = false;
            int userInput;
            ExpandableMenuItem currentExpendableMenuItemToHandle;


            while (!ExitOrBack)
            {
                printMenu();
                userInput = GetInputFromUser(m_MenuItems.Count());
                if (userInput == 0)
                {
                    ExitOrBack = true;
                }
                else
                {
                    if (m_MenuItems[--userInput] is ExpandableMenuItem)
                    {
                        currentExpendableMenuItemToHandle = (ExpandableMenuItem)m_MenuItems[userInput--];
                        currentExpendableMenuItemToHandle.show();
                    }
                    else
                    {
                        m_MenuItems[userInput--].HandleSelectedItem();
                    }
                }
            }
        }

        private void printMenu()
        {
            Console.Clear();
            Console.WriteLine("**{0}**", ItemTitle);
            Console.WriteLine("-----------------------");
            int count = 1;
            foreach (MenuItem item in m_MenuItems)
            {
                if (item.ItemTitle != "Exit" && item.ItemTitle != "Back")
                {
                    Console.WriteLine("{0} -> {1}", count, item.ItemTitle);
                    count++;
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", 0, item.ItemTitle);
                }
            }
            Console.WriteLine("-----------------------");
        }

        public static int GetInputFromUser(int i_MenuItemsAmount)
        {
            bool isValidInput = false;
            string userInput;
            int validInput = 0;

            while (!isValidInput)
            {
                try
                {
                    Console.WriteLine(@"Please Enter your input: (1 to {0} or press '0' to Back).", i_MenuItemsAmount - 1);
                    userInput = Console.ReadLine();
                    GetAndCheckInput(i_MenuItemsAmount, userInput, out isValidInput, out validInput);
                }
                catch (ArgumentOutOfRangeException argEx)
                {
                    Console.WriteLine(argEx.Message);
                }
                catch (FormatException frmtEx)
                {
                    Console.WriteLine(frmtEx.Message);
                }
            }

            return validInput;
        }

        public static void GetAndCheckInput(int i_MenuItemsAmount, string i_UserInput, out bool o_IsValidInput, out int o_InputParsedToInt)
        {
            o_IsValidInput = true;
            o_InputParsedToInt = 0;

            if (!(int.TryParse(i_UserInput, out o_InputParsedToInt)))
            {
                o_IsValidInput = false;
                throw new FormatException("Input must be a number.");
            }

            if ((o_InputParsedToInt < 0) || (o_InputParsedToInt >= i_MenuItemsAmount))
            {
                o_IsValidInput = false;
                throw new ArgumentOutOfRangeException();
            }

        }
    }
}
