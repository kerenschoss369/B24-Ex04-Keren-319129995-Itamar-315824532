using Ex04.Menus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class EventsMenu
    {
        public MenuItem m_MainMenu;

        public EventsMenu()
        {
            m_MainMenu = new ExpandableMenuItem("Events Main Menu");
            NonExpandableMenuItem showDateTime = new NonExpandableMenuItem("Show Date/Time");
            NonExpandableMenuItem showDateTime = new NonExpandableMenuItem("Show Date/Time");

        }
    }
}
