using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspTallerMecanico.Data.DDL
{
    public class TipoServicio
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(75, ErrorMessage = "El campo {0} debe tener un maximo de {1} caracteres.")]
        public string Nombre { get; set; }

        public ICollection<ServicioMecanico> ServicioMecanicos { get; set; }

    }
}
