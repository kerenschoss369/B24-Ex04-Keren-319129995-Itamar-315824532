using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    internal class ExpandableMenuItem : MenuItem
    {
        protected List<MenuItem> m_MenuItems;
        public ExpandableMenuItem(string i_Title) : base(i_Title)
        {
        }
        private void printMenu()
        {
            Console.WriteLine("**{0}**", Title);
            Console.WriteLine("-----------------------");
            int count = 1;
            foreach (MenuItem item in m_MenuItems)
            {
                Console.WriteLine("{0} -> {1}", count, item.Title);
                count++;
            }
            Console.WriteLine("-----------------------");
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
        public override void HandleSelectedItem()
        {
            //COMPLETE
            //OnChosen();
        }
        public void AddSubMenu(MenuItem i_MenuItem)
        {
            if (m_MenuItems == null)
            {
                m_MenuItems = new List<MenuItem>();
            }
            m_MenuItems.Add(i_MenuItem);

            //FIX- add listener to list throw test?
        }
    }
}
