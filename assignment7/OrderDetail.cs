using System;
using System.Collections.Generic;

namespace OrderApp
{
    public class OrderDetail
    {
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public float TotalPrice => Product.Price * Quantity;

        public OrderDetail() { }

        public OrderDetail(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            var detail = obj as OrderDetail;
            return detail != null && EqualityComparer<Product>.Default.Equals(Product, detail.Product);
        }

        public override int GetHashCode()
        {
            return 785010553 + EqualityComparer<Product>.Default.GetHashCode(Product);
        }

        public override string ToString()
        {
            return $"OrderDetail: {Product}, Quantity: {Quantity}";
        }
    }
}
