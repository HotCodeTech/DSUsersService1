﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UsersService.Data;

namespace UsersService.Data.Migrations
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20211023164450_add-mgration addedFKIdtoVehicles")]
    partial class addmgrationaddedFKIdtoVehicles
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UsersService.Data.Entities.AddressEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apartment")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("UsersService.Data.Entities.AuthorizationLevelEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("AuthLevels");
                });

            modelBuilder.Entity("UsersService.Data.Entities.BusinessEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int?>("BusinessProfileId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("BusinessProfileId");

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("UsersService.Data.Entities.CustomerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int?>("UserAddressId")
                        .HasColumnType("int");

                    b.Property<int?>("UserCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("UserProfileId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserAddressId");

                    b.HasIndex("UserCategoryId");

                    b.HasIndex("UserProfileId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("UsersService.Data.Entities.PermissionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorizationLevelEntityId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorizationLevelEntityId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("UsersService.Data.Entities.ProfileEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AvatarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AvatarId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("UsersService.Data.Entities.ProfilePicEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<string>("SourcePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProfilePics");
                });

            modelBuilder.Entity("UsersService.Data.Entities.UserCategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthLevelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthLevelId");

                    b.ToTable("UserCategories");
                });

            modelBuilder.Entity("UsersService.Data.Entities.VehicleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Mileage")
                        .HasMaxLength(8)
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("RegistrationNumber")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("VIN")
                        .HasMaxLength(17)
                        .HasColumnType("nvarchar(17)");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("UsersService.Data.Entities.BusinessEntity", b =>
                {
                    b.HasOne("UsersService.Data.Entities.AddressEntity", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("UsersService.Data.Entities.ProfileEntity", "BusinessProfile")
                        .WithMany()
                        .HasForeignKey("BusinessProfileId");

                    b.Navigation("Address");

                    b.Navigation("BusinessProfile");
                });

            modelBuilder.Entity("UsersService.Data.Entities.CustomerEntity", b =>
                {
                    b.HasOne("UsersService.Data.Entities.AddressEntity", "UserAddress")
                        .WithMany()
                        .HasForeignKey("UserAddressId");

                    b.HasOne("UsersService.Data.Entities.UserCategoryEntity", "UserCategory")
                        .WithMany()
                        .HasForeignKey("UserCategoryId");

                    b.HasOne("UsersService.Data.Entities.ProfileEntity", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId");

                    b.Navigation("UserAddress");

                    b.Navigation("UserCategory");

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("UsersService.Data.Entities.PermissionEntity", b =>
                {
                    b.HasOne("UsersService.Data.Entities.AuthorizationLevelEntity", null)
                        .WithMany("Permissions")
                        .HasForeignKey("AuthorizationLevelEntityId");
                });

            modelBuilder.Entity("UsersService.Data.Entities.ProfileEntity", b =>
                {
                    b.HasOne("UsersService.Data.Entities.ProfilePicEntity", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId");

                    b.Navigation("Avatar");
                });

            modelBuilder.Entity("UsersService.Data.Entities.UserCategoryEntity", b =>
                {
                    b.HasOne("UsersService.Data.Entities.AuthorizationLevelEntity", "AuthLevel")
                        .WithMany()
                        .HasForeignKey("AuthLevelId");

                    b.Navigation("AuthLevel");
                });

            modelBuilder.Entity("UsersService.Data.Entities.VehicleEntity", b =>
                {
                    b.HasOne("UsersService.Data.Entities.CustomerEntity", "Customer")
                        .WithMany("Vehicles")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("UsersService.Data.Entities.AuthorizationLevelEntity", b =>
                {
                    b.Navigation("Permissions");
                });

            modelBuilder.Entity("UsersService.Data.Entities.CustomerEntity", b =>
                {
                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
