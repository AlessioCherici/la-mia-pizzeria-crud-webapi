using Microsoft.EntityFrameworkCore;
using MyPizzeriaModel.Models;

namespace MyPizzeriaModel
    {
    public class PizzaContext : DbContext
        {
        public DbSet<Pizza> Pizzas { get; set; }

        public DbSet<Categoria> Categorie { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {

            optionsBuilder.UseSqlServer("Data Source=localhost;Database=PizzeriaDB;Integrated Security=True;TrustServerCertificate=True");

            }
        }
    }
