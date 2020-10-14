using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab4_Entity_v4.Models
{
    class Exercise
    {
        public int ExerciseId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Repetition { get; set; }
        public List<UserWorkout> userWorkouts { get; set; }
    }
}
