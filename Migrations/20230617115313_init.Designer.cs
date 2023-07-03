﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TiketApi.Context;

#nullable disable

namespace TiketApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230617115313_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TiketApi.Models.TiketModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Dari")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HargaTiket")
                        .HasColumnType("int");

                    b.Property<string>("Ke")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Komentar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamaPenumpang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("NomorPenumpang")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("WaktuBuat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WaktuSkrg")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WaktuUpdate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tikets");
                });
#pragma warning restore 612, 618
        }
    }
}
