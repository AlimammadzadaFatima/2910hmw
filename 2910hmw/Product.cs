using System;
using System.Collections.Generic;
using System.Text;

namespace _2910hmw
{
    class Product
    {
        public Product (int no, int count, int price, string name)
        {
            this.Name = name;
            this.No = no;
            this.Count = count;
            this.Price = price;
        }
        public string Name;
        public int No;
        public int Count;
        public int Price;
    }
}
