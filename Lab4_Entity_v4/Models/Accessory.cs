using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab4_Entity_v4.Models
{
    class Accessory
    {
        public int AccessoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public List<UserWorkout> userWorkouts { get; set; }
    }
}
