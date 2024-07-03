using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    internal class MenuItem
    {
        string m_Title;
        protected List<Interface> m_ItemListeners = new List<Interface>();
        int m_ItemIndex;
        ExpandableMenuItem m_SubMenu;

        public MenuItem(string i_ItemTitle, int i_ItemIndex, List<MenuItem> i_SubMenu)
        {
            m_Title = i_ItemTitle;
            m_ItemIndex = i_ItemIndex;
            m_SubMenu = new MenuItemWithSubMenu(i_SubMenu);
        }
        public MenuItem(string i_ItemTitle, int i_ItemIndex)
        {
            m_Title = i_ItemTitle;
            m_ItemIndex = i_ItemIndex;
            m_SubMenu = null;
        }

        public void AddItemToItemListenersList(Interface i_ItemListener)
        {
            m_ItemListeners.Add(i_ItemListener);
        }

        public void RemoveItemFromItemListenersList(Interface itemListener)
        {
            m_ItemListeners.Remove(itemListener);
        }

        protected virtual void Show()
        {
            Console.Clear();
            Console.WriteLine("** {0} **", m_Title);
            Console.WriteLine("-----------------------");
            foreach (KeyValuePair<int, ExpandableMenuItem> item in m_SubMenu)
            {
                item.Value.PrintItem();
            }

            getItemInTheEnd();
            m_ItemInTheEnd.PrintItem();
            Console.WriteLine("-----------------------");
        }
    }
    
}
