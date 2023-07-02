﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZaferTurizm.DataAccess;

#nullable disable

namespace ZaferTurizm.DataAccess.Migrations
{
    [DbContext(typeof(TourDbContext))]
    [Migration("20230626171916_CitySeedDataCreate")]
    partial class CitySeedDataCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ZaferTurizm.Domain.BusTrip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2(0)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<int>("RouteId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RouteId");

                    b.HasIndex("VehicleId");

                    b.ToTable("BusTrip", (string)null);
                });

            modelBuilder.Entity("ZaferTurizm.Domain.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("City", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Adana"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Ankara"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Antalya"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Bursa"
                        },
                        new
                        {
                            Id = 34,
                            Name = "İstanbul"
                        },
                        new
                        {
                            Id = 35,
                            Name = "İzmir"
                        });
                });

            modelBuilder.Entity("ZaferTurizm.Domain.Passenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<byte>("Gender")
                        .HasColumnType("tinyint");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Passenger", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Tsubasa",
                            Gender = (byte)2,
                            IdentityNumber = "12345667874",
                            LastName = "Ozora"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Sanae",
                            Gender = (byte)1,
                            IdentityNumber = "8764873564",
                            LastName = "Ozora"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Taro",
                            Gender = (byte)2,
                            IdentityNumber = "3486384743",
                            LastName = "Misaki"
                        });
                });

            modelBuilder.Entity("ZaferTurizm.Domain.Route", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArrivalCityId")
                        .HasColumnType("int");

                    b.Property<int>("DepartureCityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArrivalCityId");

                    b.HasIndex("DepartureCityId");

                    b.ToTable("Route", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArrivalCityId = 34,
                            DepartureCityId = 35
                        },
                        new
                        {
                            Id = 2,
                            ArrivalCityId = 6,
                            DepartureCityId = 34
                        },
                        new
                        {
                            Id = 3,
                            ArrivalCityId = 7,
                            DepartureCityId = 34
                        },
                        new
                        {
                            Id = 4,
                            ArrivalCityId = 35,
                            DepartureCityId = 6
                        });
                });

            modelBuilder.Entity("ZaferTurizm.Domain.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BusTripId")
                        .HasColumnType("int");

                    b.Property<int>("PassengerId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BusTripId");

                    b.HasIndex("PassengerId");

                    b.ToTable("Ticket", (string)null);
                });

            modelBuilder.Entity("ZaferTurizm.Domain.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PlateNumber")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("VehicleDefinitionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleDefinitionId");

                    b.ToTable("Vehicle", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PlateNumber = "34 ABC 123",
                            VehicleDefinitionId = 1
                        },
                        new
                        {
                            Id = 2,
                            PlateNumber = "34 CDE 654",
                            VehicleDefinitionId = 1
                        },
                        new
                        {
                            Id = 3,
                            PlateNumber = "34 QWE 345",
                            VehicleDefinitionId = 2
                        },
                        new
                        {
                            Id = 4,
                            PlateNumber = "34 ZXC 987",
                            VehicleDefinitionId = 3
                        });
                });

            modelBuilder.Entity("ZaferTurizm.Domain.VehicleDefinition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("HasToilet")
                        .HasColumnType("bit");

                    b.Property<bool>("HasWifi")
                        .HasColumnType("bit");

                    b.Property<int>("SeatCount")
                        .HasColumnType("int");

                    b.Property<int>("VehicleModelId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleModelId");

                    b.ToTable("VehicleDefinition", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HasToilet = false,
                            HasWifi = true,
                            SeatCount = 48,
                            VehicleModelId = 1,
                            Year = 2020
                        },
                        new
                        {
                            Id = 2,
                            HasToilet = false,
                            HasWifi = true,
                            SeatCount = 48,
                            VehicleModelId = 1,
                            Year = 2021
                        },
                        new
                        {
                            Id = 3,
                            HasToilet = false,
                            HasWifi = false,
                            SeatCount = 52,
                            VehicleModelId = 5,
                            Year = 2019
                        });
                });

            modelBuilder.Entity("ZaferTurizm.Domain.VehicleMake", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("VehicleMake", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mercedes"
                        },
                        new
                        {
                            Id = 2,
                            Name = "MAN"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Neoplan"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Otokar"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Volvo"
                        });
                });

            modelBuilder.Entity("ZaferTurizm.Domain.VehicleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("VehicleMakeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleMakeId");

                    b.ToTable("VehicleModel", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Travego",
                            VehicleMakeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "403",
                            VehicleMakeId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Tourismo",
                            VehicleMakeId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Lions",
                            VehicleMakeId = 2
                        },
                        new
                        {
                            Id = 5,
                            Name = "Fortuna",
                            VehicleMakeId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "SL",
                            VehicleMakeId = 2
                        });
                });

            modelBuilder.Entity("ZaferTurizm.Domain.BusTrip", b =>
                {
                    b.HasOne("ZaferTurizm.Domain.Route", "Route")
                        .WithMany()
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ZaferTurizm.Domain.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Route");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("ZaferTurizm.Domain.Route", b =>
                {
                    b.HasOne("ZaferTurizm.Domain.City", "ArrivalCity")
                        .WithMany()
                        .HasForeignKey("ArrivalCityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ZaferTurizm.Domain.City", "DepartureCity")
                        .WithMany()
                        .HasForeignKey("DepartureCityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ArrivalCity");

                    b.Navigation("DepartureCity");
                });

            modelBuilder.Entity("ZaferTurizm.Domain.Ticket", b =>
                {
                    b.HasOne("ZaferTurizm.Domain.BusTrip", "BusTrip")
                        .WithMany()
                        .HasForeignKey("BusTripId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ZaferTurizm.Domain.Passenger", "Passenger")
                        .WithMany()
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("BusTrip");

                    b.Navigation("Passenger");
                });

            modelBuilder.Entity("ZaferTurizm.Domain.Vehicle", b =>
                {
                    b.HasOne("ZaferTurizm.Domain.VehicleDefinition", "VehicleDefinition")
                        .WithMany()
                        .HasForeignKey("VehicleDefinitionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("VehicleDefinition");
                });

            modelBuilder.Entity("ZaferTurizm.Domain.VehicleDefinition", b =>
                {
                    b.HasOne("ZaferTurizm.Domain.VehicleModel", "VehicleModel")
                        .WithMany()
                        .HasForeignKey("VehicleModelId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("VehicleModel");
                });

            modelBuilder.Entity("ZaferTurizm.Domain.VehicleModel", b =>
                {
                    b.HasOne("ZaferTurizm.Domain.VehicleMake", "VehicleMake")
                        .WithMany()
                        .HasForeignKey("VehicleMakeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("VehicleMake");
                });
#pragma warning restore 612, 618
        }
    }
}
