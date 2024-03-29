﻿// <auto-generated />
using System;
using EFC1.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFC1.Db.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EFC1.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("birth_date");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(75)")
                        .HasColumnName("email")
                        .HasColumnOrder(1);

                    b.Property<string>("FullName")
                        .HasColumnType("varchar(75)")
                        .HasColumnName("full_name")
                        .HasColumnOrder(2);

                    b.Property<double>("Salary")
                        .HasPrecision(14, 2)
                        .HasColumnType("double")
                        .HasColumnName("salary");

                    b.HasKey("Id");

                    b.ToTable("authors");
                });

            modelBuilder.Entity("EFC1.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("isbn");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int")
                        .HasColumnName("release_year");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
