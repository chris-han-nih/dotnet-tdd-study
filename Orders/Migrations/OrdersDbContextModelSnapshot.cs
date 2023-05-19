﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Orders;

#nullable disable

namespace Orders.Migrations
{
    [DbContext(typeof(OrdersDbContext))]
    partial class OrdersDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Orders.Order", b =>
                {
                    b.Property<long>("Sequence")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Sequence"));

                    b.Property<DateTime?>("CancelledAtUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("PaidAtUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("PlaceAtUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("ShippedAtUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("ShopId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("StartedAtUtc")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Sequence");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ShopId");

                    b.HasIndex("Status");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
