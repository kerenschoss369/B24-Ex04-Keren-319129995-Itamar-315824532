using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    internal class ExpandableMenuItem : MenuItem
    {
        protected List<MenuItem> m_SubMenu;
        public ExpandableMenuItem(string i_Title) : base(i_Title)
        {
        }
        public override void HandleSelectedItem()
        {
            /*bool quit = false;
            while (!quit)
            {
                showMenu();
                int choise = askForInput(m_SubMenu.Count);
                if (choise != 0)
                {

                    m_SubMenu[choise - 1].OnMenuAsked(m_SubMenu[choise - 1]);
                }
                else
                {
                    quit = true;
                }
            }*/
        }

        public void AddSubMenu(MenuItem i_MenuItem)
        {
            if (m_SubMenu == null)
            {
                m_SubMenu = new List<MenuItem>();
            }
            m_SubMenu.Add(i_MenuItem);

            //FIX- add listener to list throw test
        }
    }
}
