using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartoszEgrowskiLab2
{
    public class Grade
    {
        public double gradeValue { get; set; }
        public string gradeName { get; set; }
        public Grade (double gradeValue, string gradeName)
        {
            this.gradeValue = gradeValue;
            this.gradeName = gradeName;
        }       
    }
}
