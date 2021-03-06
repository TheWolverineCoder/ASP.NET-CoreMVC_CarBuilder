﻿// <auto-generated />
using CarBuilder.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarBuilder.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20210302093903_third")]
    partial class third
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarBuilder.Entities.Car", b =>
                {
                    b.Property<string>("CarID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EngineDisplacement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InteriorColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InteriorMaterial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarBuilder.Entities.Client", b =>
                {
                    b.Property<string>("ClientID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("CarBuilder.Entities.Garagee", b =>
                {
                    b.Property<int>("GarageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClientID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GarageID");

                    b.HasIndex("CarID");

                    b.HasIndex("ClientID");

                    b.ToTable("Garages");
                });

            modelBuilder.Entity("CarBuilder.Entities.Garagee", b =>
                {
                    b.HasOne("CarBuilder.Entities.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarID");

                    b.HasOne("CarBuilder.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID");

                    b.Navigation("Car");

                    b.Navigation("Client");
                });
#pragma warning restore 612, 618
        }
    }
}
