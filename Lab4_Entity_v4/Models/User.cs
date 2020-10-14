using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab4_Entity_v4.Models
{
    class User
    {
        public int UserId { get; set; }
        [NotMapped]
        public string Name { get; set; }
        public List<UserWorkout> userWorkouts { get; set; }
        [MaxLength(255)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(255)]
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
