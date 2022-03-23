using System;
using System.Collections.Generic;
using System.Text;

namespace task22_3
{
    class Book:Product
    {
        public Book(int no, string name, double price, string Genre): base(no, name, price)
        {
            
        }

    
    public string Genre;
    }
}
