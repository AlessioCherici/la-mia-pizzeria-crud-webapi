using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPizzeriaModel.Models;
using MyPizzeriaModel;

namespace My_pizzeria_Model.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class PizzeController : ControllerBase
        {

        [HttpGet]

        public IActionResult Get(string searchString)
            {
            using PizzaContext db = new PizzaContext();
            List<Pizza> listaPizze = db.Pizzas.Where( item => item.Nome == searchString  ).ToList();
            
            return Ok(listaPizze);
            }
        }
    }
