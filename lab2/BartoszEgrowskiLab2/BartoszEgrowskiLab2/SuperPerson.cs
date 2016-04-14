using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartoszEgrowskiLab2
{
    class SuperPerson : Person
    {
        public int amountOfHands = 0;
        public SuperPerson (string name, string surname, int age, int amountOfHands)
            :base (surname, name, age)
        {

        }
    }
}
