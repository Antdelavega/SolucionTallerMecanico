﻿// <auto-generated />
using System;
using AspTallerMecanico.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspTallerMecanico.Migrations
{
    [DbContext(typeof(AspTallerMecanicoContext))]
    [Migration("20190911150114_InitialDB")]
    partial class InitialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspTallerMecanico.Data.DDL.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NIT")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("AspTallerMecanico.Data.DDL.ServicioMecanico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescripcionServicio")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("FechaEntregaVehiculo");

                    b.Property<DateTime>("FechaIngresoVehiculo");

                    b.Property<int?>("TipoServicioId");

                    b.Property<int?>("VehiculoId");

                    b.HasKey("Id");

                    b.HasIndex("TipoServicioId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("ServicioMecanico");
                });

            modelBuilder.Entity("AspTallerMecanico.Data.DDL.TipoServicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.HasKey("Id");

                    b.ToTable("TipoServicio");
                });

            modelBuilder.Entity("AspTallerMecanico.Data.DDL.TipoVehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("TipoVehiculo");
                });

            modelBuilder.Entity("AspTallerMecanico.Data.DDL.Vehiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NumeroChasis")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NumeroMotor")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("NumeroPlaca")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<int?>("TipoVehiculoId");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("TipoVehiculoId");

                    b.ToTable("Vehiculo");
                });

            modelBuilder.Entity("AspTallerMecanico.Data.DDL.ServicioMecanico", b =>
                {
                    b.HasOne("AspTallerMecanico.Data.DDL.TipoServicio", "TipoServicio")
                        .WithMany("ServicioMecanicos")
                        .HasForeignKey("TipoServicioId");

                    b.HasOne("AspTallerMecanico.Data.DDL.Vehiculo", "Vehiculo")
                        .WithMany()
                        .HasForeignKey("VehiculoId");
                });

            modelBuilder.Entity("AspTallerMecanico.Data.DDL.Vehiculo", b =>
                {
                    b.HasOne("AspTallerMecanico.Data.DDL.Clientes", "Cliente")
                        .WithMany("Vehiculos")
                        .HasForeignKey("ClienteId");

                    b.HasOne("AspTallerMecanico.Data.DDL.TipoVehiculo", "TipoVehiculo")
                        .WithMany("Vehiculos")
                        .HasForeignKey("TipoVehiculoId");
                });
#pragma warning restore 612, 618
        }
    }
}
