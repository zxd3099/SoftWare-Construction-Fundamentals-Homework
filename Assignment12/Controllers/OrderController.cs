using System;
using System.Collections.Generic;
using System.Linq;
using Assignment12.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment12.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderContext ctx;
        public OrderController(OrderContext ctx)
        {
            this.ctx = ctx;
        }

        [HttpGet]
        public ActionResult<List<Order>> GetOrders(string clientName, string address, double? money)
        {
            var query = buildQuery(clientName, address, money);
            return query.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetTodoItem(string id)
        {
            var query = ctx.Orders.Include(o=>o.OrderClient).Include(o=>o.OrderDetails).ThenInclude(o => o.OrderGoods).Where(o => o.OrderID.Equals(id)).FirstOrDefault();
            if (query == null)
            {
                return NotFound();
            }
            return query;
        }

        [HttpGet("pageQuery")]
        public ActionResult<List<Order>> queryOrders(string clientName, string address, double? money, int skip, int take)
        {
            var query = buildQuery(clientName, address, money).Skip(skip).Take(take);
            return query.ToList();
        }

        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            FixOrder(order);
            try
            {
                ctx.Orders.Add(order);
                ctx.SaveChanges();
            } catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        [HttpPut("{id}")]
        public ActionResult<Order> PutOrder(string id, Order order) 
        {
            if (id != order.OrderID)
                return BadRequest("Id is unmodified!!!");
            try
            {
                ctx.Entry(order).State = EntityState.Modified;
                ctx.SaveChanges();
            } catch (Exception e)
            {
                string error = e.Message;
                if(e.InnerException != null)
                    error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(string id)
        {
            try
            {
                var target = ctx.Orders.Include(o => o.OrderClient).Include(o => o.OrderDetails).ThenInclude(o => o.OrderGoods).FirstOrDefault(t => t.OrderID == id);
                if (target != null)
                {
                    ctx.OrderDetails.RemoveRange(target.OrderDetails);
                    ctx.Remove(target);
                    ctx.SaveChanges();
                }
            } catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

        private IQueryable<Order> buildQuery(string clientName, string address, double? money) 
        {
            var query = ctx.Orders.Include("OrderDetails");
            if (clientName != null)
            {
                query = query.Include(o => o.OrderClient).Where(o => o.OrderClient.Name.Equals(clientName));
            }
            if (address != null)
            {
                query = query.Where(o => o.DeliveryAddress.Equals(address));
            }
            if(money != null)
            {
                query = query.Where(o => o.OrderDetails.Sum(d => d.Amount * d.OrderGoods.Price) >= money);
            }
            query = query.Include(o => o.OrderDetails).ThenInclude(o => o.OrderGoods);
            return query;
        }
        
        private void FixOrder(Order order)
        {
            order.ClientID = order.OrderClient.ClientID;
            order.OrderClient = null;
            order.OrderDetails.ForEach(
                d => {
                    d.GoodsID = d.OrderGoods.GoodsID;
                    d.OrderGoods = null;
                }
            );
        }
    }
}
