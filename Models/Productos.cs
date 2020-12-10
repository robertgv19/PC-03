using System;
using System.ComponentModel.DataAnnotations;

namespace PC_03.Models
{
    public class Productos
    { 
        
        
        public int id { get; set; }
        [Required]
        public string nombre{ get; set; }
        [Required]
        public string imagen { get; set; }
        [Required]
        public string descripcion { get; set; }
        [Required]
        public double precio { get; set; }
        [Required]
        public string celular { get; set; }
        [Required]
        public string lugarcompra { get; set; }
        [Required]
        public string usuario { get; set; }
    }
}
