using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace OrderApp
{
    public class OrderService : DbContext
    {
        // DbSet 用于映射数据库中的表
        public DbSet<Order> orders { get; set; }

        // 构造函数，指定数据库连接字符串
        public OrderService() : base("name=OrderDBConnection")
        {
        }

        // 添加订单
        public void AddOrder(Order order)
        {
            var existingOrder = orders.FirstOrDefault(o => o.Id == order.Id);
            if (existingOrder != null)
            {
                MessageBox.Show($"Order with ID {order.Id} already exists.");
                throw new ApplicationException($"Order with ID {order.Id} already exists.");
            }
            orders.Add(order);
            SaveChanges();  // 保存更改到数据库
        }

        // 更新订单
        public void UpdateOrder(Order order)
        {
            var existingOrder = orders.FirstOrDefault(o => o.Id == order.Id);
            if (existingOrder == null)
            {
                MessageBox.Show($"Order with ID {order.Id} doesn't exist.");
                throw new ApplicationException($"Order with ID {order.Id} doesn't exist.");
            }

            // 更新现有订单的属性
            existingOrder.Customer.Name = order.Customer.Name;
            existingOrder.CreateTime = order.CreateTime;
            // 可以继续添加更多需要更新的属性...
            SaveChanges();
        }

        // 根据 ID 查询订单
        public Order GetOrder(int orderId)
        {
            return orders.FirstOrDefault(o => o.Id == orderId);
        }

        // 根据 ID 删除订单
        public void RemoveOrder(int orderId)
        {
            var orderToRemove = orders.FirstOrDefault(o => o.Id == orderId);
            if (orderToRemove != null)
            {
                orders.Remove(orderToRemove);
                SaveChanges();  // 保存更改到数据库
                MessageBox.Show("Order deleted successfully.");
            }
            else
            {
                MessageBox.Show($"Order with ID {orderId} not found.");
            }
        }

        // 查询所有订单
        public List<Order> QueryAll()
        {
            return orders.ToList();  // 返回所有订单
        }

        // 根据客户名称查询订单
        public List<Order> QueryByCustomerName(string customerName)
        {
            var query = orders
                .Where(o => o.Customer.Name.Equals(customerName, StringComparison.OrdinalIgnoreCase))
                .OrderBy(o => o.TotalPrice);
            return query.ToList();
        }

        // 根据产品名称查询订单
        public List<Order> QueryByProductName(string productName)
        {
            var query = orders
                .Where(o => o.Details.Any(d => d.Product.Name.Equals(productName, StringComparison.OrdinalIgnoreCase)))
                .OrderBy(o => o.TotalPrice);
            return query.ToList();
        }

        // 根据总价查询订单
        public List<Order> QueryByTotalPrice(float totalPrice)
        {
            var query = orders
                .Where(o => o.TotalPrice >= totalPrice)
                .OrderBy(o => o.TotalPrice);
            return query.ToList();
        }

        // 对订单列表进行排序
        public void Sort(Comparison<Order> comparison)
        {
            var orderList = orders.ToList();  // 将 DbSet 转换为 List 以便排序
            orderList.Sort(comparison);
            // 目前排序只是内存中的排序，若需要更新数据库中的顺序，需要更复杂的操作
        }

        // 根据传入的条件查询订单
        public IEnumerable<Order> Query(Predicate<Order> condition)
        {
            return orders.Where(o => condition(o)).OrderBy(o => o.TotalPrice);
        }
    }
}
