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
	        private static List<Order> orders = new List<Order> {
            		new Order { ID = 1, customerName = "Dude",   },
            		new Order { Id= 2, Name = "Batman"    },
            		new Order { Id= 3, Name = "Spiderman" }
        	};
		
		[HttpGet]
		public ActionResult<List<Order>> Get()
		{
			return "Success!";
		}
		
		[HttpPost]
		public ActionResult Create(Order newOrder)
		{
		    var existingSuperheroItem = Superheroes.Find(x => x.Id == superheroItem.Id)
		    if (existingSuperheroItem != null)
		    {
			return Conflict("Cannot create the Id because it already exists.");
		    }
		    else
		    {
			Superheroes.Add(superheroItem);
			var resourceUrl = Request.Path.ToString() + '/' + superheroItem.Id;
			return Created(resourceUrl, superheroItem);
		    }
		}
	}
}
