using System;
using OrderManagement.Models;
using OrderManagement.Services;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Customer c1 = new Customer("FCB");
            Customer c2 = new Customer("GSW");
            Goods apple = new Goods("苹果", 5);
            Goods milk = new Goods("牛奶", 8);

            OrderService service = new OrderService();

            Order order1 = new Order(1, c1);
            order1.AddDetails(new OrderDetails(apple, 10));
            order1.AddDetails(new OrderDetails(milk, 2));
            service.AddOrder(order1);

            Order order2 = new Order(2, c2);
            order2.AddDetails(new OrderDetails(milk, 5));
            service.AddOrder(order2);

            Console.WriteLine("初始订单列表：");
            service.ShowAll();

            Console.WriteLine("\n查询包含牛奶的订单：");
            var queryResult = service.QueryOrders(o => o.DetailsList.Any(d => d.Goods.Name == "牛奶"));
            queryResult.ForEach(Console.WriteLine);

            Console.WriteLine("\n修改订单1的客户为Steph");
            service.ModifyOrder(1, new Customer("Steph"));
            service.ShowAll();

            Console.WriteLine("\n删除订单2");
            service.DeleteOrder(2);
            service.ShowAll();

            Console.WriteLine("\n排序（默认按订单号）：");
            service.Sort();
            service.ShowAll();

            Console.WriteLine("\n按订单金额排序：");
            service.Sort((o1, o2) => o1.TotalAmount.CompareTo(o2.TotalAmount));
            service.ShowAll();
        }
        catch (ApplicationException ex)
        {
            Console.WriteLine($"错误：{ex.Message}");
        }
    }
}
