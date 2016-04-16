using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartoszEgrowskiLab2
{
    class Grade
    {
        double gradeValue { get; set; }
        string gradeName { get; set; }
        public Grade (double gradeValue, string gradeName)
        {
            this.gradeValue = gradeValue;
            this.gradeName = gradeName;
        }
    }
}
