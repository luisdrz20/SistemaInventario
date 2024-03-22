using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo nombre es requerido")]
        [MaxLength(60, ErrorMessage = "El nombre solo se compone de 60 carac")]
        public String Nombre { get; set; }
        [Required(ErrorMessage = "El campo Descripcion es requerido")]
        [MaxLength(100, ErrorMessage = "La descripción solo se compone de 100")]
        public String Descripcion { get; set; }
        [Required(ErrorMessage = "El Estado de la bodega es requerido")]
        public bool Estado { get; set; }


    }
}
