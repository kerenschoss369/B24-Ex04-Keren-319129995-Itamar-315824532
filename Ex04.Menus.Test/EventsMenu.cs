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
        public ExpandableMenuItem m_MainMenu; 
        ShowDateListener m_ShowDateListener = new ShowDateListener();
        ShowTimeListener m_ShowTimeListener = new ShowTimeListener();
        ShowVersionListener m_ShowVersionListener = new ShowVersionListener();
        CountCapitalsListener m_CountCapitalsListener = new CountCapitalsListener();

        public EventsMenu()
        {
            NonExpandableMenuItem showDate = new NonExpandableMenuItem("Show Time");
            NonExpandableMenuItem showTime = new NonExpandableMenuItem("Show Date");
            NonExpandableMenuItem showVersion = new NonExpandableMenuItem("Show Version");
            NonExpandableMenuItem countCapitals = new NonExpandableMenuItem("Count Capitals");
            ExpandableMenuItem showDateTime = new ExpandableMenuItem("Show Date/Time");
            ExpandableMenuItem showVersionOrCountCapitals = new ExpandableMenuItem("Version And Capitals");
            ExpandableMenuItem eventsMenu = new ExpandableMenuItem("Events Main Menu");
            
            //not sure about it for now
            NonExpandableMenuItem exit = new NonExpandableMenuItem("Exit");
            NonExpandableMenuItem back = new NonExpandableMenuItem("Back");

            showDate.Chosen += m_ShowDateListener.ChosenAction;
            showTime.Chosen += m_ShowTimeListener.ChosenAction;
            showVersion.Chosen += m_ShowVersionListener.ChosenAction;
            countCapitals.Chosen += m_CountCapitalsListener.ChosenAction;

            showDateTime.AddMenuItem(showDate);
            showDateTime.AddMenuItem(showTime);
            showDateTime.AddMenuItem(back);// FIX
            showVersionOrCountCapitals.AddMenuItem(showVersion);
            showVersionOrCountCapitals.AddMenuItem(countCapitals);
            showVersionOrCountCapitals.AddMenuItem(back);// FIX
            eventsMenu.AddMenuItem(showDateTime);
            eventsMenu.AddMenuItem(showVersionOrCountCapitals);
            eventsMenu.AddMenuItem(exit);// FIX
            m_MainMenu = eventsMenu;
        }
    }
}
