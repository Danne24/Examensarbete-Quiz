﻿// <auto-generated />
using Examensarbete_Quiz.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examensarbete_Quiz.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230614023706_1")]
    partial class _1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Examensarbete_Quiz.Models.Question", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionID"));

                    b.Property<string>("CorrectOption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Option1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Option2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Option3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Option4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionID");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionID = 1,
                            CorrectOption = "2",
                            Option1 = "1",
                            Option2 = "2",
                            Option3 = "3",
                            Option4 = "4",
                            Point = 0,
                            QuestionText = "Vad är 1+1?"
                        },
                        new
                        {
                            QuestionID = 2,
                            CorrectOption = "4",
                            Option1 = "2",
                            Option2 = "4",
                            Option3 = "6",
                            Option4 = "8",
                            Point = 0,
                            QuestionText = "Vad är 2+2?"
                        },
                        new
                        {
                            QuestionID = 3,
                            CorrectOption = "6",
                            Option1 = "3",
                            Option2 = "6",
                            Option3 = "9",
                            Option4 = "12",
                            Point = 0,
                            QuestionText = "Vad är 3+3?"
                        });
                });

            modelBuilder.Entity("Examensarbete_Quiz.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<int>("UserAge")
                        .HasColumnType("int");

                    b.Property<string>("UserFirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserGender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserLastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            UserAge = 26,
                            UserFirstName = "Daniel",
                            UserGender = "Male",
                            UserLastName = "Gyrén"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
