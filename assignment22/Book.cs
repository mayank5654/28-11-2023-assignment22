using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment22
{
    internal class Book
    {
        
            public int BookId { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string Genre { get; set; }
            public bool IsAvailable { get; set; }

            public override string ToString()
            {
                return $"ID: {BookId}, Title: {Title}, Author: {Author}, Genre: {Genre}, Available: {IsAvailable}";
            }
        
    }
}
