using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    internal class MainMenu : MenuItem
    {
        //SubMenu m_SubMenu;
        List<MenuItem> m_MenuItems;

        public MainMenu(string i_ItemTitle, int i_ItemIndex, List<MenuItem> i_SubMenu) : base(i_ItemTitle, i_ItemIndex, i_SubMenu)
        {
            MenuItem exitItem = new MenuItem("Exit", 0);
            m_MenuItems.Add(exitItem);
        }

        public void Show()
        {

        }
    }
}
