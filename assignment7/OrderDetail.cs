using System;

namespace OrderApp
{
    public class OrderDetail
    {
        public Goods Goods { get; set; } // 更改 Product 为 Goods

        public int Quantity { get; set; }

        public float TotalPrice
        {
            get => Goods.Price * Quantity; // 更改 Product 为 Goods
        }

        public OrderDetail() { }

        public OrderDetail(Goods goods, int quantity) // 更改 Product 为 Goods
        {
            this.Goods = goods; // 更改 Product 为 Goods
            this.Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            var detail = obj as OrderDetail;
            return detail != null &&
                   EqualityComparer<Goods>.Default.Equals(Goods, detail.Goods); // 更改 Product 为 Goods
        }

        public override int GetHashCode()
        {
            return 785010553 + EqualityComparer<Goods>.Default.GetHashCode(Goods); // 更改 Product 为 Goods
        }

        public override string ToString()
        {
            return $"OrderDetail:{Goods},{Quantity}"; // 更改 Product 为 Goods
        }
    }
}
