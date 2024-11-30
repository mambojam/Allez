﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241130112026_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("Domain.Block", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("Grade")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("GymId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Rating")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Blocks");
                });

            modelBuilder.Entity("Domain.Route", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("Grade")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("GymId")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Rating")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Routes");
                });
#pragma warning restore 612, 618
        }
    }
}
