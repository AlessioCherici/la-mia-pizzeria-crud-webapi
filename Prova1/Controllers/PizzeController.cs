using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPizzeriaModel.Models;
using MyPizzeriaModel;
using Microsoft.EntityFrameworkCore;

namespace My_pizzeria_Model.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class PizzeController : ControllerBase
        {

        [HttpGet]

        public IActionResult Get(string? search)
            {
            using PizzaContext db = new PizzaContext();
            List<Pizza> listaPizze = new List<Pizza>();
            if (search == null || search == "")
                {
                listaPizze = db.Pizzas.ToList();
                return Ok(listaPizze);
                }
            else
                {
                search = search.ToLower();
                listaPizze = db.Pizzas.Where(pizzaScelta => pizzaScelta.Nome.ToLower().Contains(search)).ToList();
                return Ok(listaPizze);  
                }
            }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
            {
            using (PizzaContext context = new PizzaContext())
                {
                Pizza pizza = context.Pizzas.Where(pizza => pizza.Id == id).Include(pizza => pizza.Categoria).FirstOrDefault();

                if (pizza == null)
                    {
                    return NotFound();
                    }

                return Ok(pizza);
                }
            }
        }
    }
