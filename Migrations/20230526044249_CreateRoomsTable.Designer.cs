﻿// <auto-generated />
using HotelManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelManagement.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230526044249_CreateRoomsTable")]
    partial class CreateRoomsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("HotelManagement.Models.Rooms", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("heads_per_room")
                        .HasColumnType("INTEGER");

                    b.Property<string>("hostel_description")
                        .HasColumnType("TEXT");

                    b.Property<int>("hostel_id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("hostel_name")
                        .HasColumnType("TEXT");

                    b.Property<float>("rate")
                        .HasColumnType("REAL");

                    b.Property<string>("type_of_food")
                        .HasColumnType("TEXT");

                    b.Property<string>("type_of_rooms")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("hostels");
                });
#pragma warning restore 612, 618
        }
    }
}