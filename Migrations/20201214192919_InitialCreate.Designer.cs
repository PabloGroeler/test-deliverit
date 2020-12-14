﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using test_deliverit.src.Core.Data.Context;

namespace test_deliverit.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201214192919_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("test_deliverit.src.Core.Domain.Entities.ContaPagarEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DiasAtraso")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<decimal>("PercentualJuroDia")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PercentualMulta")
                        .HasColumnType("numeric");

                    b.Property<decimal>("ValorCorrigido")
                        .HasColumnType("numeric");

                    b.Property<decimal>("ValorOriginal")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("ContasPagar");
                });
#pragma warning restore 612, 618
        }
    }
}