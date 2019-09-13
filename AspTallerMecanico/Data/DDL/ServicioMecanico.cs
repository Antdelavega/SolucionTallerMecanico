using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace AspTallerMecanico.Data.DDL
{
    public class ServicioMecanico
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaIngresoVehiculo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaEntregaVehiculo { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "El campo (0) debe tener un maxiomo de 50 caracteres.")]
        public string DescripcionServicio { get; set; }

        //Llave Foranea Vehiculo a Servicio Mecanico

        [ForeignKey("Vehiculo")]
        public int VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }



        [ForeignKey("TipoServicio")]
        public int TipoServicioId { get; set; }
        public TipoServicio TipoServicio { get; set; }
    }
}
