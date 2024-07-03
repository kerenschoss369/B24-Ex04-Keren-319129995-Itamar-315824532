using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    internal class ExpandableMenuItem : MenuItem
    {
        private List<MenuItem> m_MenuItems;
        public ExpandableMenuItem(string i_Title) : base(i_Title)
        {
        }
        public override void HandleSelectedItem()
        {
            OnChosen();
        }
        public void AddMenuItem(MenuItem i_MenuItem)
        {
            m_MenuItems?.Add(i_MenuItem);
        }
        public void HandleSelectedItem(int i_UserInput)
        {
            bool ExitOrBack = false;

            while (!ExitOrBack)
            {
                printMenu();
                if (i_UserInput == 0)
                {
                    ExitOrBack = true;
                }
                else
                {
                    m_MenuItems[i_UserInput--].HandleSelectedItem();
                }
            }
        }

        private void printMenu()
        {
            Console.WriteLine("**{0}**", ItemTitle);
            Console.WriteLine("-----------------------");
            int count = 1;
            foreach (MenuItem item in m_MenuItems)
            {
                Console.WriteLine("{0} -> {1}", count, item.ItemTitle);
                count++;
            }
            Console.WriteLine("-----------------------");
        }
    }
}
