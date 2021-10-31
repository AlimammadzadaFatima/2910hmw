using System;
using System.Collections.Generic;
using System.Text;

namespace _2910hmw
{
    class Book : Product
    {
        public Book (string name,int count,int no,int price, string genre) : base(no, count, price, name)
        { 
        this.Genre = genre;
        }
    public string Genre;
        public string GetInput()
        {
            return $"Name: {this.Name}, Count: {this.Count}, No: {this.No}, Price: {this.Price}, Genre: {this.Genre}";
        }

    }
}
