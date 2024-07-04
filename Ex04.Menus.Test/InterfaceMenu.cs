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
        public ExpandableMenuItem m_MainMenu; //should be MenuItem
        ShowVersionListener m_ShowVersionListener = new ShowVersionListener();
        CountCapitalsListener m_CountCapitalsListener = new CountCapitalsListener();
        ShowDateListener m_ShowDateListener = new ShowDateListener();
        ShowTimeListener m_ShowTimeListener = new ShowTimeListener();

        public InterfaceMenu()
        {
            NonExpandableMenuItem showVersion = new NonExpandableMenuItem("Show Version");
            NonExpandableMenuItem countCapitals = new NonExpandableMenuItem("Count Capitals");
            NonExpandableMenuItem showDate = new NonExpandableMenuItem("Show Time");
            NonExpandableMenuItem showTime = new NonExpandableMenuItem("Show Date");
            ExpandableMenuItem showVersionOrCountCapitals = new ExpandableMenuItem("Version And Capitals");
            ExpandableMenuItem showDateTime = new ExpandableMenuItem("Show Date/Time");
            ExpandableMenuItem eventsMenu = new ExpandableMenuItem("Events Main Menu");

            /*showVersion.Chosen += m_ShowVersionListener.ChosenAction;
            countCapitals.Chosen += m_CountCapitalsListener.ChosenAction;
            showDate.Chosen += m_ShowDateListener.ChosenAction;
            showTime.Chosen += m_ShowTimeListener.ChosenAction;*/
            //the above code needs to be replaced with add listeners


            showVersionOrCountCapitals.AddMenuItem(showVersion);
            showVersionOrCountCapitals.AddMenuItem(countCapitals);
            showDateTime.AddMenuItem(showDate);
            showDateTime.AddMenuItem(showTime);
            eventsMenu.AddMenuItem(showVersionOrCountCapitals);
            eventsMenu.AddMenuItem(showDateTime);
            m_MainMenu = eventsMenu;
            //The none greened part needs to add the itemms to the menus names are correct but need to implement method
        }
    }
}
