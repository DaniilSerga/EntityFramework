using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model.DatabaseModels
{
    internal class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int AuthorId { get; set; }

        public int CountryId { get; set; }

        public int GenreId { get; set; }

        public Author Author { get; set; }

        public Country Country { get; set; }

        public Genre Genre { get; set; }
    }
}
