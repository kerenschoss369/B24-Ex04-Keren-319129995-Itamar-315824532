using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    public abstract class MenuItem
    {
        protected string m_ItemTitle;
        public event Action<MenuItem> Chosen;

        public MenuItem(string i_Title)
        {
            m_ItemTitle = i_Title;
        }

        public string ItemTitle
        {
            get 
            {
                return m_ItemTitle; 
            }
            set 
            {
                m_ItemTitle = value; 
            }
        }
        public abstract void HandleSelectedItem();

        protected virtual void OnChosen()
        {
                Chosen?.Invoke(this);
        }
    }
}
