using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    public struct Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string ISBNNo { get; set; }
        public string Author { get; set; }

        public Book(int _id,string _name, string _genre, string _isbnno, string _author)
        {
            this.Id = _id;
            this.Name = _name;
            this.Genre = _genre;
            this.Author = _author;
            this.ISBNNo = _isbnno;
        }
    }
}
