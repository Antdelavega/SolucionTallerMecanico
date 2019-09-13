using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspTallerMecanico.Data.DDL
{
    public class Vehiculo
    {
        public int Id { get; set; }

        //  [Required]
        //   [MaxLength(10, ErrorMessage = "El campo {0} debe tener un maxiomo de {10} caracteres.")]
        public string NumeroPlaca { get; set; }

        // [Required]
        // [MaxLength(50, ErrorMessage = "El campo {0} debe tener un maxiomo de {50} caracteres.")]
        public string Descripcion { get; set; }

        // [Required]
        // [MaxLength(50, ErrorMessage = "El campo {0} debe tener un maxiomo de {50} caracteres.")]
        public string NumeroMotor { get; set; }

        //  [Required]
        // [MaxLength(50, ErrorMessage = "El campo {0} debe tener un maxiomo de {50} caracteres.")]

        public string NumeroChasis { get; set; }


        //propiedad de navegacion

            //Llave foranea clientes a vehiculo
        [ForeignKey("Clientes")]
        public int ClienteId { get; set; }
        public Clientes Cliente { get; set; }

        //Llave foranea TipoVehiculo a vehiculo

        [ForeignKey("TipoVehiculo")]
        public int TipoVehiculoId { get; set; }
        public TipoVehiculo TipoVehiculo { get; set; }

    }
}


