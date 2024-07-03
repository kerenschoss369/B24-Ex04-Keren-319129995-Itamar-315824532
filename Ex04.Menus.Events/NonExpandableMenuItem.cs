using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Events
{
    internal class NonExpandableMenuItem : MenuItem 
    {
        public NonExpandableMenuItem(string i_Title) : base(i_Title)
        {
        }
        public override void HandleSelectedItem()
        {
               OnChosen();
        }
    }
}
