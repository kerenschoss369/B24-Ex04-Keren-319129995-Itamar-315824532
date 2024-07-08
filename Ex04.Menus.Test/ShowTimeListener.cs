using Ex04.Menus.Events;
using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class ShowTimeListener : IMenuListener
    {
        private void showTime()
        {
            DateTime currentDateTime = DateTime.Now;
            TimeSpan currentHour = new TimeSpan(currentDateTime.Hour, currentDateTime.Minute, currentDateTime.Second);
            Console.WriteLine("The Hour is: {0}", currentHour);
        }

        public void ChosenAction()
        {
            showTime();
        }
    }
}
