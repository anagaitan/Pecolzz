﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pecolzz.Data;

#nullable disable

namespace Pecolzz.Migrations
{
    [DbContext(typeof(PecolzzContext))]
    [Migration("20230119154841_DataAdaugarii")]
    partial class DataAdaugarii
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Pecolzz.Models.Produs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("DataAdaugarii")
                        .HasColumnType("datetime2");

                    b.Property<string>("Denumire_produs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descriere")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("ID");

                    b.ToTable("Produs");
                });
#pragma warning restore 612, 618
        }
    }
}
