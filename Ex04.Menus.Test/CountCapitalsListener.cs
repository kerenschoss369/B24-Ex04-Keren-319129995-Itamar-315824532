using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class CountCapitalsListener
    {

        private void countCapitals()
        {
            string userInput;
            int amountOfCapitalLetters = 0;

            Console.WriteLine("Please enter a setence for capital letters count");
            userInput = Console.ReadLine();
            for (int i = 0; i < userInput.Length; i++)
            {
                if(char.IsUpper(userInput[i]))
                {
                    amountOfCapitalLetters++;
                }
            }
            Console.WriteLine("There are {0} capital letters in this sentence.", amountOfCapitalLetters);
        }
        public void ChosenAction()
        {
            countCapitals();
        }
    }
}
