using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSharp.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class OrderController : ControllerBase
	{ 
		// Created as an example without knowing database information
	        private static List<Order> orders = new List<Order> {
            		new Order { ID = 1, customerName = "Dude", itemSKU = "SKU1", itemQty = 2, itemPrice = 13.00, currencyCode = "USD", status = "ACTIVE" },
            		new Order { ID = 2, customerName = "Dudette", itemSKU = "SKU47", itemQty = 1, itemPrice = 50.00, currencyCode = "CAD", status = "CANCELLED" }
        	};
		
		[HttpGet]
		public ActionResult<List<Order>> Get()
		{
			return Ok(orders.OrderBy(x => x.customerName));
		}
		
		[HttpPost]
		public ActionResult Create(Order newOrder)
		{
		    var doesOrderExist = orders.Find(x => x.ID == newOrder.ID)
		    if (doesOrderExist != null)
		    {
			return "Order already exists.";
		    }
		    else
		    {
			orders.Add(newOrder);
			return "Success";
		    }
		}
		

		[HttpDelete]
		[Route("{Id}")]
		public ActionResult Delete(int Id)
		{
		    var order = orders.Find(x => x.ID == Id);
		    if (order == null)
		    {
			return "Order not found";
		    }
		    else
		    {
			orders.Remove(order);
			return "Success";
		    }
		}
		
		[HttpPut]
		public ActionResult Update(Order modifyOrder)
		{
		    var doesOrderExist = orders.Find(x => x.ID == modifyOrder.ID);
		    if (doesOrderExist == null)
		    {
			return "Unable to update; order doesn't exist.";
		    } 
		    else
		    {
			doesOrderExist.customerName = modifyOrder.customerName;
			return "Success";
		    }
		}
	}
}
