using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class ShowDateListener
    {
        private void showDate()
        {
            Console.WriteLine("The date is: {0}", DateTime.Now.ToShortDateString());
        }

        public void ChosenAction()
        {
            showDate();
        }

    }
}
