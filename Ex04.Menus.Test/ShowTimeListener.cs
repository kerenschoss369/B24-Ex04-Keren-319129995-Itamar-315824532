using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class ShowTimeListener
    {
        private void showTime()
        {
            Console.WriteLine("The hour is: {0}", DateTime.Now);
        }

        public void ChosenAction()
        {
            showTime();
        }
    }
}
