using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class ShowVersionListener
    {
        private void showVersion()
        {
            Console.WriteLine("Version: 24.2.4.9504");
        }

        public void ChosenAction()
        {
            showVersion();
        }
    }
}
