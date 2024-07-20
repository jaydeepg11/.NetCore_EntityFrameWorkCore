﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment2.Migrations
{
    [DbContext(typeof(ManageDbContext))]
    partial class ManageDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            Name = "Abhishek",
                            TeamID = 1
                        },
                        new
                        {
                            EmployeeID = 2,
                            Name = "Basil",
                            TeamID = 2
                        });
                });

            modelBuilder.Entity("EmployeeDetail", b =>
                {
                    b.Property<int>("EmployeeDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeDetailID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeDetailID");

                    b.HasIndex("EmployeeID")
                        .IsUnique();

                    b.ToTable("EmployeeDetail");

                    b.HasData(
                        new
                        {
                            EmployeeDetailID = 1,
                            Address = "Maharashtra",
                            EmployeeID = 1
                        },
                        new
                        {
                            EmployeeDetailID = 2,
                            Address = "Goa",
                            EmployeeID = 2
                        });
                });

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID", "ProjectID");

                    b.HasIndex("ProjectID");

                    b.ToTable("EmployeeProjects");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            ProjectID = 2
                        },
                        new
                        {
                            EmployeeID = 2,
                            ProjectID = 1
                        });
                });

            modelBuilder.Entity("Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectID"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectID");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectID = 1,
                            Name = "Angular"
                        },
                        new
                        {
                            ProjectID = 2,
                            Name = "Python"
                        });
                });

            modelBuilder.Entity("Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamID"));

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamID");

                    b.ToTable("Team");

                    b.HasData(
                        new
                        {
                            TeamID = 1,
                            TeamName = "ICONS"
                        },
                        new
                        {
                            TeamID = 2,
                            TeamName = "STRIKERS"
                        });
                });

            modelBuilder.Entity("Employee", b =>
                {
                    b.HasOne("Team", "team")
                        .WithMany("employees")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("team");
                });

            modelBuilder.Entity("EmployeeDetail", b =>
                {
                    b.HasOne("Employee", "employee")
                        .WithOne("employeeDetail")
                        .HasForeignKey("EmployeeDetail", "EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");
                });

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.HasOne("Employee", "employee")
                        .WithMany("employeeProjects")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project", "project")
                        .WithMany("employeeProjects")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");

                    b.Navigation("project");
                });

            modelBuilder.Entity("Employee", b =>
                {
                    b.Navigation("employeeDetail");

                    b.Navigation("employeeProjects");
                });

            modelBuilder.Entity("Project", b =>
                {
                    b.Navigation("employeeProjects");
                });

            modelBuilder.Entity("Team", b =>
                {
                    b.Navigation("employees");
                });
#pragma warning restore 612, 618
        }
    }
}
