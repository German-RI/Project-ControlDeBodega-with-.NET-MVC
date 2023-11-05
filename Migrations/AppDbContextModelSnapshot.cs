﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectControlBodega.Models;

#nullable disable

namespace ProjectControlBodega.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjectControlBodega.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("ProjectControlBodega.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellidos")
                        .HasColumnType("longtext");

                    b.Property<string>("Cedula")
                        .HasColumnType("longtext");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .HasColumnType("longtext");

                    b.Property<string>("Sexo")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ProjectControlBodega.Models.CompaniaDeEnvio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Correo")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.Property<double>("Precio")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("CompaniaDeEnvios");
                });

            modelBuilder.Entity("ProjectControlBodega.Models.Detalledepedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("CantidadProducto")
                        .HasColumnType("double");

                    b.Property<int?>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProductoId");

                    b.ToTable("Detalledepedidos");
                });

            modelBuilder.Entity("ProjectControlBodega.Models.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellidos")
                        .HasColumnType("longtext");

                    b.Property<string>("Cedula")
                        .HasColumnType("longtext");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .HasColumnType("longtext");

                    b.Property<string>("Sexo")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("ProjectControlBodega.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int?>("CompdeenvioId")
                        .HasColumnType("int");

                    b.Property<int?>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("CompdeenvioId");

                    b.HasIndex("EmpleadoId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("ProjectControlBodega.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Imagen")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<double>("Precio")
                        .HasColumnType("double");

                    b.Property<int?>("ProveedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("ProveedorId");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("ProjectControlBodega.Models.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<string>("Direccion")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<double>("Telefono")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Proveedors");
                });

            modelBuilder.Entity("ProjectControlBodega.Models.Detalledepedido", b =>
                {
                    b.HasOne("ProjectControlBodega.Models.Pedido", "Pedido")
                        .WithMany("Detalledepedidos")
                        .HasForeignKey("PedidoId");

                    b.HasOne("ProjectControlBodega.Models.Producto", "Producto")
                        .WithMany("Detalledepedidos")
                        .HasForeignKey("ProductoId");

                    b.Navigation("Pedido");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("ProjectControlBodega.Models.Pedido", b =>
                {
                    b.HasOne("ProjectControlBodega.Models.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId");

                    b.HasOne("ProjectControlBodega.Models.CompaniaDeEnvio", "Compdeenvio")
                        .WithMany("Pedidos")
                        .HasForeignKey("CompdeenvioId");

                    b.HasOne("ProjectControlBodega.Models.Empleado", "Empleado")
                        .WithMany("Pedidos")
                        .HasForeignKey("EmpleadoId");

                    b.Navigation("Cliente");

                    b.Navigation("Compdeenvio");

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("ProjectControlBodega.Models.Producto", b =>
                {
                    b.HasOne("ProjectControlBodega.Models.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaId");

                    b.HasOne("ProjectControlBodega.Models.Proveedor", "Proveedor")
                        .WithMany("Productos")
                        .HasForeignKey("ProveedorId");

                    b.Navigation("Categoria");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("ProjectControlBodega.Models.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("ProjectControlBodega.Models.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("ProjectControlBodega.Models.CompaniaDeEnvio", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("ProjectControlBodega.Models.Empleado", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("ProjectControlBodega.Models.Pedido", b =>
                {
                    b.Navigation("Detalledepedidos");
                });

            modelBuilder.Entity("ProjectControlBodega.Models.Producto", b =>
                {
                    b.Navigation("Detalledepedidos");
                });

            modelBuilder.Entity("ProjectControlBodega.Models.Proveedor", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
