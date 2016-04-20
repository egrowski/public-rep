using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BartoszEgrowskiPD2
{
    public class ComicBook:Book
    {
        public string draftsman { get; set; }
        public string publisher { get; set; }  // string? (opcja wyboru)
        public string color { get; set; }   // to co wyżej
        public ComicBook (string title, string author, string rating, string draftsman, string publisher, string color)
        :base (title, author, rating)
        {

        }
        public ComicBook()
            {
            }
    }
}
