using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab4_Entity_v4.Models
{
    class Workout
    {
        public int WorkoutId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Type { get; set; } 
        public List<UserWorkout> userWorkouts { get; set; }
    }
}
