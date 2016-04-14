using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartoszEgrowskiLab2
{
    class Person
    {
        public List<Grade> listOfGrades = new List<Grade>();
        public string surname { get; set; }
        public string name { get; set; }
        public int age {get; set; }
        public Person (string surname, string name, int age)
        {
            this.surname = surname;
            this.name = name;
            this.age = age;
        }
       
        public Person() { }
        
    }
}
