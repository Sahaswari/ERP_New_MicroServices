﻿// <auto-generated />
using System;
using ERP.TrainingManagement.DataServices.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ERP.TrainingManagement.DataServices.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240702120400_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("ERP.TrainingManagement.Core.Entities.ApprovalRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("ApprovedById")
                        .HasColumnType("TEXT");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("TEXT");

                    b.Property<int>("status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ApprovedById");

                    b.HasIndex("StudentId");

                    b.ToTable("ApprovalRequests");
                });

            modelBuilder.Entity("ERP.TrainingManagement.Core.Entities.CVUpload", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("TEXT");

                    b.Property<int>("status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("CVUploads");
                });

            modelBuilder.Entity("ERP.TrainingManagement.Core.Entities.Coordinator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Coordinators");
                });

            modelBuilder.Entity("ERP.TrainingManagement.Core.Entities.InternshipVacancy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CoordinatorId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CoordinatorId");

                    b.ToTable("InternshipVacancies");
                });

            modelBuilder.Entity("ERP.TrainingManagement.Core.Entities.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Regesiter_Number")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ERP.TrainingManagement.Core.Entities.ApprovalRequest", b =>
                {
                    b.HasOne("ERP.TrainingManagement.Core.Entities.Coordinator", "ApprovedBy")
                        .WithMany("ApprovedRequests")
                        .HasForeignKey("ApprovedById");

                    b.HasOne("ERP.TrainingManagement.Core.Entities.Student", "Student")
                        .WithMany("ApprovalRequests")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApprovedBy");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ERP.TrainingManagement.Core.Entities.CVUpload", b =>
                {
                    b.HasOne("ERP.TrainingManagement.Core.Entities.Student", "Student")
                        .WithMany("CVUploads")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ERP.TrainingManagement.Core.Entities.InternshipVacancy", b =>
                {
                    b.HasOne("ERP.TrainingManagement.Core.Entities.Coordinator", "Coordinator")
                        .WithMany("InternshipVacancies")
                        .HasForeignKey("CoordinatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coordinator");
                });

            modelBuilder.Entity("ERP.TrainingManagement.Core.Entities.Coordinator", b =>
                {
                    b.Navigation("ApprovedRequests");

                    b.Navigation("InternshipVacancies");
                });

            modelBuilder.Entity("ERP.TrainingManagement.Core.Entities.Student", b =>
                {
                    b.Navigation("ApprovalRequests");

                    b.Navigation("CVUploads");
                });
#pragma warning restore 612, 618
        }
    }
}
