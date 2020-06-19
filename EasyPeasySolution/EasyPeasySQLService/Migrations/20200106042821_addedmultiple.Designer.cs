﻿// <auto-generated />
using EasyPeasySQLService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EasyPeasySQLService.Migrations
{
    [DbContext(typeof(EasyPeasyContext))]
    [Migration("20200106042821_addedmultiple")]
    partial class addedmultiple
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EasyPeasyDataModel.Classes.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyNameAddition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("EasyPeasyDataModel.Classes.AddressAddressType", b =>
                {
                    b.Property<int>("AddressID")
                        .HasColumnType("int");

                    b.Property<int>("AddressTypeID")
                        .HasColumnType("int");

                    b.HasKey("AddressID", "AddressTypeID");

                    b.HasIndex("AddressTypeID");

                    b.ToTable("AddressAddressType");
                });

            modelBuilder.Entity("EasyPeasyDataModel.Classes.AddressType", b =>
                {
                    b.Property<int>("AddressTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressTypeID");

                    b.ToTable("AddressTypes");
                });

            modelBuilder.Entity("EasyPeasyDataModel.Classes.Address", b =>
                {
                    b.OwnsOne("EasyPeasyDataModel.Classes.PhoneNumber", "Fax", b1 =>
                        {
                            b1.Property<int>("AddressID")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Number")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Prefix")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("AddressID");

                            b1.ToTable("Addresses");

                            b1.WithOwner()
                                .HasForeignKey("AddressID");
                        });

                    b.OwnsOne("EasyPeasyDataModel.Classes.PhoneNumber", "PhoneLandline", b1 =>
                        {
                            b1.Property<int>("AddressID")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Number")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Prefix")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("AddressID");

                            b1.ToTable("Addresses");

                            b1.WithOwner()
                                .HasForeignKey("AddressID");
                        });

                    b.OwnsOne("EasyPeasyDataModel.Classes.PhoneNumber", "PhoneMobile", b1 =>
                        {
                            b1.Property<int>("AddressID")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Number")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Prefix")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("AddressID");

                            b1.ToTable("Addresses");

                            b1.WithOwner()
                                .HasForeignKey("AddressID");
                        });
                });

            modelBuilder.Entity("EasyPeasyDataModel.Classes.AddressAddressType", b =>
                {
                    b.HasOne("EasyPeasyDataModel.Classes.Address", "Address")
                        .WithMany("AddressAddressTypes")
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyPeasyDataModel.Classes.AddressType", "AddressType")
                        .WithMany("AddressAddressTypes")
                        .HasForeignKey("AddressTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}