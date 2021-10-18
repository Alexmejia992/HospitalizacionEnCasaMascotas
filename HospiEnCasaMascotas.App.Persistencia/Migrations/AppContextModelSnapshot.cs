﻿// <auto-generated />
using System;
using HospiEnCasaMascotas.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospiEnCasaMascotas.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("HospiEnCasaMascotas.App.Dominio.HistoriaClinica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Diagnostico")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HistoriasClinicas");
                });

            modelBuilder.Entity("HospiEnCasaMascotas.App.Dominio.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Edad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreMascota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("generoMascota")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Mascotas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Mascota");
                });

            modelBuilder.Entity("HospiEnCasaMascotas.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("HospiEnCasaMascotas.App.Dominio.SignoVital", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MascotaPacienteId")
                        .HasColumnType("int");

                    b.Property<int>("Signo")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("MascotaPacienteId");

                    b.ToTable("SignosVitales");
                });

            modelBuilder.Entity("HospiEnCasaMascotas.App.Dominio.SugerenciaCuidado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HistoriaClinicaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HistoriaClinicaId");

                    b.ToTable("SugerenciasCuidado");
                });

            modelBuilder.Entity("HospiEnCasaMascotas.App.Dominio.MascotaPaciente", b =>
                {
                    b.HasBaseType("HospiEnCasaMascotas.App.Dominio.Mascota");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Latitud")
                        .HasColumnType("real");

                    b.Property<float>("Longitud")
                        .HasColumnType("real");

                    b.Property<int?>("auxiliarId")
                        .HasColumnType("int");

                    b.Property<int?>("historiaId")
                        .HasColumnType("int");

                    b.Property<int?>("propietarioId")
                        .HasColumnType("int");

                    b.Property<int?>("veterinarioId")
                        .HasColumnType("int");

                    b.HasIndex("auxiliarId");

                    b.HasIndex("historiaId");

                    b.HasIndex("propietarioId");

                    b.HasIndex("veterinarioId");

                    b.HasDiscriminator().HasValue("MascotaPaciente");
                });

            modelBuilder.Entity("HospiEnCasaMascotas.App.Dominio.Auxiliar", b =>
                {
                    b.HasBaseType("HospiEnCasaMascotas.App.Dominio.Persona");

                    b.Property<int>("NumPermiso")
                        .HasColumnType("int");

                    b.Property<float>("horas_laborales")
                        .HasColumnType("real");

                    b.HasDiscriminator().HasValue("Auxiliar");
                });

            modelBuilder.Entity("HospiEnCasaMascotas.App.Dominio.PropietarioDesignado", b =>
                {
                    b.HasBaseType("HospiEnCasaMascotas.App.Dominio.Persona");

                    b.Property<string>("contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("PropietarioDesignado");
                });

            modelBuilder.Entity("HospiEnCasaMascotas.App.Dominio.Veterinario", b =>
                {
                    b.HasBaseType("HospiEnCasaMascotas.App.Dominio.Persona");

                    b.Property<int>("NumPermiso")
                        .HasColumnType("int")
                        .HasColumnName("Veterinario_NumPermiso");

                    b.Property<string>("contraseña")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Veterinario_contraseña");

                    b.Property<string>("correo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Veterinario_correo");

                    b.Property<string>("especialidad")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Veterinario");
                });

            modelBuilder.Entity("HospiEnCasaMascotas.App.Dominio.SignoVital", b =>
                {
                    b.HasOne("HospiEnCasaMascotas.App.Dominio.MascotaPaciente", null)
                        .WithMany("SignosVitales")
                        .HasForeignKey("MascotaPacienteId");
                });

            modelBuilder.Entity("HospiEnCasaMascotas.App.Dominio.SugerenciaCuidado", b =>
                {
                    b.HasOne("HospiEnCasaMascotas.App.Dominio.HistoriaClinica", null)
                        .WithMany("Sugerencias")
                        .HasForeignKey("HistoriaClinicaId");
                });

            modelBuilder.Entity("HospiEnCasaMascotas.App.Dominio.MascotaPaciente", b =>
                {
                    b.HasOne("HospiEnCasaMascotas.App.Dominio.Auxiliar", "auxiliar")
                        .WithMany()
                        .HasForeignKey("auxiliarId");

                    b.HasOne("HospiEnCasaMascotas.App.Dominio.HistoriaClinica", "historia")
                        .WithMany()
                        .HasForeignKey("historiaId");

                    b.HasOne("HospiEnCasaMascotas.App.Dominio.PropietarioDesignado", "propietario")
                        .WithMany()
                        .HasForeignKey("propietarioId");

                    b.HasOne("HospiEnCasaMascotas.App.Dominio.Veterinario", "veterinario")
                        .WithMany()
                        .HasForeignKey("veterinarioId");

                    b.Navigation("auxiliar");

                    b.Navigation("historia");

                    b.Navigation("propietario");

                    b.Navigation("veterinario");
                });

            modelBuilder.Entity("HospiEnCasaMascotas.App.Dominio.HistoriaClinica", b =>
                {
                    b.Navigation("Sugerencias");
                });

            modelBuilder.Entity("HospiEnCasaMascotas.App.Dominio.MascotaPaciente", b =>
                {
                    b.Navigation("SignosVitales");
                });
#pragma warning restore 612, 618
        }
    }
}
