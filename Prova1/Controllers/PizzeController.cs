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

        public IActionResult Get()
            {
            using PizzaContext db = new PizzaContext();
            List<Pizza> listaPizze = db.Pizzas.ToList();
            return Ok(listaPizze);
            }
        }
    }
