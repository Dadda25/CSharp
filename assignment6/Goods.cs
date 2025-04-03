using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Models
{
    public class Goods
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Goods(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString() => $"商品：{Name}，单价：{Price}";
    }
}

