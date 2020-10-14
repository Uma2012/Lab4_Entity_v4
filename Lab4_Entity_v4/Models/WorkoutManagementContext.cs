using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Lab4_Entity_v4.Models
{
    class WorkoutManagementContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Accessory> Accessories { get; set; }

        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<UserWorkout> UserWorkouts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlServer("Server = (localdb)\\MSSQLLocalDB;" +
              " Database=TrainingpassManagement_v4;Trusted_Connection=True;");
      
    }
}
