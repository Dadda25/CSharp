using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Models
{
    public class OrderDetails
    {
        public Goods Goods { get; set; }
        public int Quantity { get; set; }

        public double Amount => Goods.Price * Quantity;

        public OrderDetails(Goods goods, int quantity)
        {
            Goods = goods;
            Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details && Goods.Name == details.Goods.Name;
        }

        public override int GetHashCode() => Goods.Name.GetHashCode();

        public override string ToString() => $"{Goods}，数量：{Quantity}，金额：{Amount}";
    }
}

