﻿// <auto-generated />
using System;
using EF_PAMOKA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EF_PAMOKA.Migrations
{
    [DbContext(typeof(PavyzdinisDbContext))]
    partial class PavyzdinisDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EF_PAMOKA.Models.Automobilis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Marke")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Modelis")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("SavininkoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Automobiliai");
                });

            modelBuilder.Entity("EF_PAMOKA.Models.Daiktas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Pavadinimas")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("SavininkoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Daiktai");
                });

            modelBuilder.Entity("EF_PAMOKA.Models.Mopedas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Marke")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Modelis")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("SavininkoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Mopedai");
                });

            modelBuilder.Entity("EF_PAMOKA.Models.Savininkas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Vardas")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Savininkai");
                });

            modelBuilder.Entity("EF_PAMOKA.Models.Vartotojas", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Pastas")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Slaptazodis")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Vardas")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Vartotojai");
                });
#pragma warning restore 612, 618
        }
    }
}
