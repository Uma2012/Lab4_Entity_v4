﻿// <auto-generated />
using System;
using Lab4_Entity_v4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab4_Entity_v4.Migrations
{
    [DbContext(typeof(WorkoutManagementContext))]
    [Migration("20200105153516_CreatingRelationship")]
    partial class CreatingRelationship
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab4_Entity_v4.Models.Accessory", b =>
                {
                    b.Property<int>("AccessoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("AccessoryId");

                    b.ToTable("Accessories");
                });

            modelBuilder.Entity("Lab4_Entity_v4.Models.Exercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Repetition");

                    b.HasKey("ExerciseId");

                    b.ToTable("Exercises");
                });

            modelBuilder.Entity("Lab4_Entity_v4.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Lab4_Entity_v4.Models.UserWorkout", b =>
                {
                    b.Property<int>("UserWorkoutId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessoryID");

                    b.Property<int?>("Difficulty");

                    b.Property<int?>("ExerciseId");

                    b.Property<int?>("ExtraAccessory");

                    b.Property<int>("UserId");

                    b.Property<int>("WorkoutId");

                    b.HasKey("UserWorkoutId");

                    b.HasIndex("AccessoryID");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("UserId");

                    b.HasIndex("WorkoutId");

                    b.ToTable("UserWorkouts");
                });

            modelBuilder.Entity("Lab4_Entity_v4.Models.Workout", b =>
                {
                    b.Property<int>("WorkoutId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("EndTime");

                    b.Property<string>("Name");

                    b.Property<string>("StartTime");

                    b.Property<string>("Type");

                    b.HasKey("WorkoutId");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("Lab4_Entity_v4.Models.UserWorkout", b =>
                {
                    b.HasOne("Lab4_Entity_v4.Models.Accessory", "accessory")
                        .WithMany("userWorkouts")
                        .HasForeignKey("AccessoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Lab4_Entity_v4.Models.Exercise", "exercise")
                        .WithMany("userWorkouts")
                        .HasForeignKey("ExerciseId");

                    b.HasOne("Lab4_Entity_v4.Models.User", "user")
                        .WithMany("userWorkouts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Lab4_Entity_v4.Models.Workout", "workout")
                        .WithMany("userWorkouts")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
