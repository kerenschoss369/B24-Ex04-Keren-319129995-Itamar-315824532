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
                userInput = askForInput(m_MenuItems.Count());
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

        public static int askForInput(int i_MaxVal)//Change this, this is literally crtl c crtl v
        {
            bool validInput = false;
            // $G$ CSS-027 (-3) Missing blank lines.
            Console.WriteLine("-------------");
            Console.WriteLine(@"Please Enter your input (1 to {0} or press '0' to Back).", i_MaxVal -1);
            int resValue = 0;
            while (!validInput)
            {
                if (int.TryParse(Console.ReadLine(), out resValue))
                {
                    validInput = true;
                    // $G$ SFN-006 (-5) The "Input handling" should have managed by the Menus.Test project.
                    if (resValue < 0 || resValue > i_MaxVal)
                    {
                        validInput = false;
                    }
                }
                // $G$ CSS-006 (-2) Missing blank line, after "if / else" blocks.
                if (!validInput)
                {
                    Console.WriteLine("Invalid input.. Try Again");
                }
            }

            return resValue;
        }
    }
}
