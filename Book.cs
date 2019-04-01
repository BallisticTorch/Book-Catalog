using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Catalog
{
    public class Book
    {
        public string ISBN { get; set; }

        public string BookTitle { get; set; }

        public string AuthorFirstName { get; set; }

        public string AuthorMiddleName { get; set; }

        public string AuthorLastName { get; set; }

        public string BookSeries { get; set; }

        public string Genre { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{ BookTitle } ";

                //{ AuthorFirstName } {AuthorMiddleName } { AuthorLastName } { BookSeries } { Genre }
            }
        }
    }
}
