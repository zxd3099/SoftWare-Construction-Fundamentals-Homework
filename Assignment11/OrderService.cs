using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Assignment10
{

  public class OrderService {

    public List<Order> Orders {
      get {
              using(var ctx = new OrderContext())
              {
                    return ctx.Orders.Include(o => o.Details.Select(d => d.GoodsItem)).Include("Customer").ToList<Order>();
              }
           }
    }

    public Order GetOrder(int id) {
       using (var ctx = new OrderContext())
       {
           var query = ctx.Orders.Include(o => o.Details.Select(d => d.GoodsItem)).Include("Customer").SingleOrDefault(o => o.OrderId == id);
           if (query != null) return query;
           else return null;
       }
    }

    public void AddOrder(Order order) {
      if (Orders.Contains(order)) throw new ApplicationException($"添加错误: 订单{order.OrderId} 已经存在了!");
      using(var ctx = new OrderContext())
      {
         ctx.Entry(order).State = EntityState.Added;
         ctx.SaveChanges();
      }
    }

    public void RemoveOrder(int orderId) {
      Order order = GetOrder(orderId);
      if (order != null) {
        using(var ctx = new OrderContext())
        {
            ctx.Orders.Remove(order);
            ctx.SaveChanges();
        }
      }
    }

    public List<Order> QueryOrdersByGoodsName(string goodsName) {
     using (var ctx = new OrderContext())
     {
        var result = ctx.Orders
                    .Include(o => o.Details.Select(d => d.GoodsItem))
                    .Where(o => o.Details.Exists(d => d.GoodsName == goodsName))
                    .Include("Customer")
                    .ToList<Order>();
        if (result != null) return result;
        else throw new ApplicationException("不存在这样的订单");
     }
    }

    public List<Order> QueryOrdersByCustomerName(string customerName) {
      using(var ctx = new OrderContext())
      {
         var result = ctx.Orders
                    .Include(o => o.Details.Select(d => d.GoodsItem))
                    .Where(o => o.CustomerName == customerName)
                    .Include("Customer")
                    .ToList<Order>();
         if (result != null) return result;
         else throw new ApplicationException("不存在这样的订单");
      }
    }

    public void UpdateOrder(Order newOrder) {
      Order oldOrder = GetOrder(newOrder.OrderId);
      if(oldOrder == null) throw new ApplicationException($"修改错误：订单 {newOrder.OrderId} 不存在!");
      RemoveOrder(oldOrder.OrderId);
      AddOrder(newOrder);
    }

    public void Export(String fileName) {
      XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
      using (FileStream fs = new FileStream(fileName, FileMode.Create)) {
        xs.Serialize(fs, Orders);
      }
    }

    public void Import(string path) {
      XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
      using (FileStream fs = new FileStream(path, FileMode.Open)) {
        List<Order> temp = (List<Order>)xs.Deserialize(fs);
        temp.ForEach(order => AddOrder(order));
      }
    }

    public object QueryByTotalAmount(double amout) {
       using (var ctx = new OrderContext())
       {
           var result = ctx.Orders
                   .Include(o => o.Details.Select(d => d.GoodsItem))
                   .Where(o => o.TotalPrice == amout)
                   .Include("Customer")
                   .ToList<Order>();
           if (result != null) return result;
           else throw new ApplicationException("不存在这样的订单");
       }
    }
  }
}
