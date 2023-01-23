using MyPizzeriaModel.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPizzeriaModel.Models
    {
    [Table("Categorie")]
    public class Categoria

        {
        public int Id { get; set; }
        public string NomeCategoria { get; set; }

        public List<Pizza>? Pizzas { get; set; }


        public Categoria()
            {

            }

        public Categoria(int id, string nomeCategoria)
            {
            this.Id = id;
            this.NomeCategoria = nomeCategoria;
            }

        }
    }
