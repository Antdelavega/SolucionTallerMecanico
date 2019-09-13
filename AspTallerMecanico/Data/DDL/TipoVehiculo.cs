using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspTallerMecanico.Data.DDL
{
    public class TipoVehiculo
    {
        public int Id { get; set; }
       // [Required]
       // [MaxLength(50, ErrorMessage = "El campo {0} debe tener un maxiomo de {50} caracteres.")]
        public string Nombre { get; set; }
        public ICollection<Vehiculo> Vehiculos { get; set; }

    }
}
