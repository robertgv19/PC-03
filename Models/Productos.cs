using System;
using System.ComponentModel.DataAnnotations;

namespace PC_03.Models
{
    public class Productos
    { 
        
        
        public int id { get; set; }
        public string nombre{ get; set; }

        public string imagen { get; set; }

        public string descripcion { get; set; }

        public double precio { get; set; }

        public string celular { get; set; }

        public string lugarcompra { get; set; }

        public string usuario { get; set; }
    }
}
