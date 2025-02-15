﻿// <auto-generated />
using System;
using EFCoreAssignment_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreAssignment_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20250124133730_addedEmployeesToDb")]
    partial class addedEmployeesToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCoreAssignment_Models.Models.Employee", b =>
                {
                    b.Property<int>("EMPLOYEE_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EMPLOYEE_ID"));

                    b.Property<float>("COMMISSION_PCT")
                        .HasColumnType("real");

                    b.Property<string>("EMAIL")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("FIRST_NAME")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("HIRE_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("LAST_NAME")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("PHONE_NUMBER")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("SALARY")
                        .HasColumnType("real");

                    b.HasKey("EMPLOYEE_ID");

                    b.ToTable("Employees", "EFCoreAssignment");
                });
#pragma warning restore 612, 618
        }
    }
}
