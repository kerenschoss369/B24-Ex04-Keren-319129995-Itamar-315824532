using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ex04.Menus.Events
{
    public abstract class MenuItem
    {
        protected readonly string m_ItemTitle;
        public event Action Chosen;

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
        }
        public abstract void HandleSelectedItem();

        protected virtual void OnChosen()
        {
            Chosen?.Invoke();
            Thread.Sleep(2000);
        }
    }
}
