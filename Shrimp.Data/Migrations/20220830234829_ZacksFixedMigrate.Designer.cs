﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shrimp.Data;

#nullable disable

namespace Shrimp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220830234829_ZacksFixedMigrate")]
    partial class ZacksFixedMigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Shrimp.Data.Entities.DistrictEntity", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DistrictId"), 1L, 1);

                    b.Property<int>("AvailableResources")
                        .HasColumnType("int");

                    b.Property<int>("CodeForDress")
                        .HasColumnType("int");

                    b.Property<decimal>("CrimeRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Curfew")
                        .HasColumnType("datetime2");

                    b.Property<int>("HousesId")
                        .HasColumnType("int");

                    b.Property<int>("NameOfDistrict")
                        .HasColumnType("int");

                    b.Property<int>("PermitsNeeded")
                        .HasColumnType("int");

                    b.Property<int>("SchoolsId")
                        .HasColumnType("int");

                    b.Property<int>("WalkabilityRating")
                        .HasColumnType("int");

                    b.HasKey("DistrictId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("Shrimp.Data.Entities.SchoolEntity", b =>
                {
                    b.Property<int>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchoolId"), 1L, 1);

                    b.Property<decimal>("Costs")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfStudents")
                        .HasColumnType("int");

                    b.Property<float>("TeacherStudentRatio")
                        .HasColumnType("real");

                    b.Property<int>("TypeOfASP")
                        .HasColumnType("int");

                    b.Property<int>("TypeOfClasses")
                        .HasColumnType("int");

                    b.HasKey("SchoolId");

                    b.ToTable("Schools");
                });
#pragma warning restore 612, 618
        }
    }
}
