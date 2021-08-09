﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Safe365__Proj.DataAccess;

namespace Safe365__Proj.Migrations
{
    [DbContext(typeof(Safe365Context))]
    [Migration("20210806153057_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Safe365__Proj.Model.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BusinessName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            BusinessName = "beerpub@gmail.com",
                            DateCreated = new DateTime(2021, 8, 6, 21, 0, 56, 665, DateTimeKind.Local).AddTicks(6607),
                            DateOfBirth = new DateTime(2021, 8, 6, 21, 0, 56, 664, DateTimeKind.Local).AddTicks(2868),
                            FirstName = "personA",
                            LastName = "LastNameA"
                        },
                        new
                        {
                            CustomerId = 2,
                            BusinessName = "beerpub@gmail.com",
                            DateCreated = new DateTime(2021, 8, 6, 21, 0, 56, 665, DateTimeKind.Local).AddTicks(7117),
                            DateOfBirth = new DateTime(2021, 8, 6, 21, 0, 56, 665, DateTimeKind.Local).AddTicks(7090),
                            FirstName = "PersonB",
                            LastName = "LastNameB"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}