using Ex04.Menus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class InterfaceMenu
    {
        public Ex04.Menus.Interfaces.ExpandableMenuItem m_MainMenu;
        ShowDateListener m_ShowDateListener = new ShowDateListener();
        ShowTimeListener m_ShowTimeListener = new ShowTimeListener();
        ShowVersionListener m_ShowVersionListener = new ShowVersionListener();
        CountCapitalsListener m_CountCapitalsListener = new CountCapitalsListener();

        public InterfaceMenu()
        {
            Ex04.Menus.Interfaces.NonExpandableMenuItem showDate = new Ex04.Menus.Interfaces.NonExpandableMenuItem("Show Date");
            Ex04.Menus.Interfaces.NonExpandableMenuItem showTime = new Ex04.Menus.Interfaces.NonExpandableMenuItem("Show Time");
            Ex04.Menus.Interfaces.NonExpandableMenuItem showVersion = new Ex04.Menus.Interfaces.NonExpandableMenuItem("Show Version");
            Ex04.Menus.Interfaces.NonExpandableMenuItem countCapitals = new Ex04.Menus.Interfaces.NonExpandableMenuItem("Count Capitals");
            Ex04.Menus.Interfaces.ExpandableMenuItem showDateTime = new Ex04.Menus.Interfaces.ExpandableMenuItem("Show Date/Time");
            Ex04.Menus.Interfaces.ExpandableMenuItem showVersionOrCountCapitals = new Ex04.Menus.Interfaces.ExpandableMenuItem("Version And Capitals");
            Ex04.Menus.Interfaces.ExpandableMenuItem interfaceMenu = new Ex04.Menus.Interfaces.ExpandableMenuItem("Interface Main Menu");
            Ex04.Menus.Interfaces.NonExpandableMenuItem exit = new Ex04.Menus.Interfaces.NonExpandableMenuItem("Exit");
            Ex04.Menus.Interfaces.NonExpandableMenuItem back = new Ex04.Menus.Interfaces.NonExpandableMenuItem("Back");
            showDate.AddListener(m_ShowDateListener);
            showTime.AddListener(m_ShowTimeListener);
            showVersion.AddListener(m_ShowVersionListener);
            countCapitals.AddListener(m_CountCapitalsListener);
            showDateTime.AddMenuItem(showTime);
            showDateTime.AddMenuItem(showDate);
            showDateTime.AddMenuItem(back);
            showVersionOrCountCapitals.AddMenuItem(showVersion);
            showVersionOrCountCapitals.AddMenuItem(countCapitals);
            showVersionOrCountCapitals.AddMenuItem(back);
            interfaceMenu.AddMenuItem(showDateTime);
            interfaceMenu.AddMenuItem(showVersionOrCountCapitals);
            interfaceMenu.AddMenuItem(exit);
            m_MainMenu = interfaceMenu;
        }
    }
}
