using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem 
    {
        string m_Title;
        protected List<IMenuListener> m_ItemListeners = new List<IMenuListener>();

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public MenuItem(string title)
        {
            m_Title = title;
        }

        public void AddListener(IMenuListener listener)
        {
            if (listener != null && !m_ItemListeners.Contains(listener))
            {
                m_ItemListeners.Add(listener);
            }
        }
        public void RemoveListener(IMenuListener listener)
        {
            if (listener != null && m_ItemListeners.Contains(listener))
            {
                m_ItemListeners.Remove(listener);
            }
        }
        public abstract void HandleSelectedItem();



    }

}
