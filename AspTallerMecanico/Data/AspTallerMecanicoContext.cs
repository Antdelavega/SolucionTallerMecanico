using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspTallerMecanico.Data.DDL;

namespace AspTallerMecanico.Models
{
    public class AspTallerMecanicoContext : DbContext
    {
        public AspTallerMecanicoContext (DbContextOptions<AspTallerMecanicoContext> options)
            : base(options)
        {
        }

        public DbSet<AspTallerMecanico.Data.DDL.Clientes> Clientes { get; set; }

        public DbSet<AspTallerMecanico.Data.DDL.Vehiculo> Vehiculo { get; set; }

        public DbSet<AspTallerMecanico.Data.DDL.TipoVehiculo> TipoVehiculo { get; set; }

        public DbSet<AspTallerMecanico.Data.DDL.TipoServicio> TipoServicio { get; set; }

        public DbSet<AspTallerMecanico.Data.DDL.ServicioMecanico> ServicioMecanico { get; set; }
    }
}
