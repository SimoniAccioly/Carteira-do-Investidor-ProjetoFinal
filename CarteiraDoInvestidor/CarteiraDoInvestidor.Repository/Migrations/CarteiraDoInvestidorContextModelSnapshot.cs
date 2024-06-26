﻿// <auto-generated />
using System;
using CarteiraDoInvestidor.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarteiraDoInvestidor.Repository.Migrations
{
    [DbContext(typeof(CarteiraDoInvestidorContext))]
    partial class CarteiraDoInvestidorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarteiraDoInvestidor.Domain.Carteira.ArquivoExcel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CarteiraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LinkExcel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarteiraId");

                    b.ToTable("Arquivos", (string)null);
                });

            modelBuilder.Entity("CarteiraDoInvestidor.Domain.Carteira.Ativos", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CarteiraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Corretora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Papel")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<double>("PrecoMedio")
                        .HasColumnType("float");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<double>("TaxaDeCorretagem")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CarteiraId");

                    b.ToTable("Ativos", (string)null);
                });

            modelBuilder.Entity("CarteiraDoInvestidor.Domain.Carteira.Carteira", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<string>("NomeCarteira")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Carteira", (string)null);
                });

            modelBuilder.Entity("CarteiraDoInvestidor.Domain.Conta.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios", (string)null);
                });

            modelBuilder.Entity("CarteiraDoInvestidor.Domain.Carteira.ArquivoExcel", b =>
                {
                    b.HasOne("CarteiraDoInvestidor.Domain.Carteira.Carteira", null)
                        .WithMany("LinkExcel")
                        .HasForeignKey("CarteiraId");
                });

            modelBuilder.Entity("CarteiraDoInvestidor.Domain.Carteira.Ativos", b =>
                {
                    b.HasOne("CarteiraDoInvestidor.Domain.Carteira.Carteira", null)
                        .WithMany("Ativos")
                        .HasForeignKey("CarteiraId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CarteiraDoInvestidor.Domain.Conta.Usuario", b =>
                {
                    b.OwnsOne("CarteiraDoInvestidor.Domain.Conta.ValueObject.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("UsuarioId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Valor")
                                .IsRequired()
                                .HasMaxLength(1024)
                                .HasColumnType("nvarchar(1024)")
                                .HasColumnName("Email");

                            b1.HasKey("UsuarioId");

                            b1.ToTable("Usuarios");

                            b1.WithOwner()
                                .HasForeignKey("UsuarioId");
                        });

                    b.OwnsOne("CarteiraDoInvestidor.Domain.Conta.ValueObject.Password", "Password", b1 =>
                        {
                            b1.Property<Guid>("UsuarioId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Valor")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Password");

                            b1.HasKey("UsuarioId");

                            b1.ToTable("Usuarios");

                            b1.WithOwner()
                                .HasForeignKey("UsuarioId");
                        });

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("Password")
                        .IsRequired();
                });

            modelBuilder.Entity("CarteiraDoInvestidor.Domain.Carteira.Carteira", b =>
                {
                    b.Navigation("Ativos");

                    b.Navigation("LinkExcel");
                });
#pragma warning restore 612, 618
        }
    }
}
