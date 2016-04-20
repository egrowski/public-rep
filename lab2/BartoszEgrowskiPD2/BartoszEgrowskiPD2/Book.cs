using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BartoszEgrowskiPD2
{
    public class Book
    {
        
        public string title { get; set; }
        public string author { get; set; }
        public string rating { get; set; }
        public string description { get; set; }
        public string CoverPath { get; set; }

        public Book (string title, string author, string rating)
        {
            this.title = title;
            this.author = author;
            this.rating = rating;
        }
        public Book()
        {
        }

        public static implicit operator PictureBox(Book v)
        {
            throw new NotImplementedException();
        }
    }
}
