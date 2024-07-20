﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment2.Migrations
{
    [DbContext(typeof(Assignment2DbContext))]
    [Migration("20240719185432_Assignment2_1.0")]
    partial class Assignment2_10
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assignment2.Employee.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("Assignment2.EmployeeDetail.EmployeeDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID")
                        .IsUnique();

                    b.ToTable("EmployeeDetail");
                });

            modelBuilder.Entity("Assignment2.Project.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectID"));

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("Assignment2.EmployeeDetail.EmployeeDetail", b =>
                {
                    b.HasOne("Assignment2.Employee.Employee", "employee")
                        .WithOne("Detail")
                        .HasForeignKey("Assignment2.EmployeeDetail.EmployeeDetail", "EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");
                });

            modelBuilder.Entity("Assignment2.Project.Project", b =>
                {
                    b.HasOne("Assignment2.Employee.Employee", "employee")
                        .WithMany("projects")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");
                });

            modelBuilder.Entity("Assignment2.Employee.Employee", b =>
                {
                    b.Navigation("Detail");

                    b.Navigation("projects");
                });
#pragma warning restore 612, 618
        }
    }
}
