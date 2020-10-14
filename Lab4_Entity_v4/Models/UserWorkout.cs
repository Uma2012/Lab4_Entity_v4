using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab4_Entity_v4.Models
{
    class UserWorkout
    {
        public int UserWorkoutId { get; set; }
        public int UserId { get; set; }
        public int WorkoutId { get; set; }
        public int AccessoryID { get; set; }
        [NotMapped]
        public int? ExtraAccessory { get; set; }
        public int? ExerciseId { get; set; }
       [DefaultValue(5)]
        public int? Difficulty { get; set; }
        public User user { get; set; }
        public Workout workout { get; set; }
        public Accessory accessory { get; set; }
        public Exercise exercise { get; set; }
    }
}
