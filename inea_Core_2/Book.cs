using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inea_Core_2
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Autor { get; set; }
        public int PagesCount { get; set; }
    }
}
