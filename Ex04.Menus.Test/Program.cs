using Ex04.Menus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            //EventsMenu eventsMenu = new EventsMenu();
            //eventsMenu.m_MainMenu.show();

            InterfaceMenu interfaceMenu = new InterfaceMenu();
            interfaceMenu.m_MainMenu.show();
        }
    }
}
