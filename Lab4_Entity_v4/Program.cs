using Lab4_Entity_v4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Lab4_Entity_v4
{
    class Program
    {
        static void Main(string[] args)
        {
           // USER TABLE DATA
            using (var db = new WorkoutManagementContext())
            {
                var user1 = new User();
                // user1.Name = "Thomas Thungberg";
                user1.FirstName = "Thomas";
                user1.LastName = "Thungberg";
                db.Add(user1);
                var user2 = new User();
                //user2.Name = "Mattias Karlsson";
                user2.FirstName = "Mattias";
                user2.LastName = "Karlsson";
                db.Add(user2);
                var user3 = new User();
                // user3.Name = "Katarin Peterson";
                user3.FirstName = "Katarin";
                user3.LastName = "Petersson";

                db.Add(user3);
                db.SaveChanges();


            }
            //ACCESSORY TABLE DATA
            using (var db = new WorkoutManagementContext())
            {
                var accesory1 = new Accessory();
                accesory1.Name = "Skor";
                db.Add(accesory1);
                var accesory2 = new Accessory();
                accesory2.Name = "Towel";
                db.Add(accesory2);
                var accesory3 = new Accessory();
                accesory3.Name = "YogaMat";
                db.Add(accesory3);
                var accesory4 = new Accessory();
                accesory4.Name = "SwimCap";
                db.Add(accesory4);
                var accesory5 = new Accessory();
                accesory5.Name = "SmartWatch";
                db.Add(accesory5);
                db.SaveChanges();

            }

            //WORKOUT TABLE DATA
            using (var db = new WorkoutManagementContext())
            {
                var workout1 = new Workout();
                workout1.Name = "Lekis";
                workout1.Description = "Motion";
                workout1.StartTime = "07:15";
                workout1.EndTime = "08:15";
                workout1.Type = "Cykling";
                db.Add(workout1);


                var workout2 = new Workout();
                workout2.Name = "skoldpadda";
                workout2.Description = "Motion";
                workout2.StartTime = "09:00";
                workout2.EndTime = "10:00";
                workout2.Type = "Swimming";
                db.Add(workout2);


                var workout3 = new Workout();
                workout3.Name = "Lekrum";
                workout3.Description = "Dance";
                workout3.StartTime = "16:30";
                workout3.EndTime = "17:30";
                workout3.Type = "Zumba";
                db.Add(workout3);


                var workout4 = new Workout();
                workout4.Name = "Peace";
                workout4.Description = "Breathing";
                workout4.StartTime = "18:45";
                workout4.EndTime = "19:45";
                workout4.Type = "Yoga";
                db.Add(workout4);


                var workout5 = new Workout();
                workout5.Name = "Sweat";
                workout5.Description = "Motion";
                workout5.StartTime = "19:50";
                workout5.EndTime = "20:50";
                workout5.Type = "Jogging";
                db.Add(workout5);
                db.SaveChanges();


            }
            //  EXERCISE TABLE DATA
            using (var db = new WorkoutManagementContext())
            {
                var exercise1 = new Exercise();
                exercise1.Name = "Water arm Lifts";
                exercise1.Repetition = "10";
                db.Add(exercise1);

                var exercise2 = new Exercise();
                exercise2.Name = "BackWall Glide";
                exercise2.Repetition = "5 min";
                db.Add(exercise2);

                var exercise3 = new Exercise();
                exercise3.Name = "Pranayama";
                exercise3.Repetition = "20 min";
                db.Add(exercise3);

                var exercise4 = new Exercise();
                exercise4.Name = "Mountain Climbing";
                exercise4.Repetition = "20 min";
                db.Add(exercise4);

                var exercise5 = new Exercise();
                exercise5.Name = "Macho Dance";
                exercise5.Repetition = "25 min";
                db.Add(exercise5);

                db.SaveChanges();
            }
            //USERWORKOUT TABLE DATA
            using (var db = new WorkoutManagementContext())
            {
                var UW1 = new UserWorkout();
                UW1.UserId = 2;
                UW1.WorkoutId = 2;
                UW1.AccessoryID = 4;
                UW1.ExtraAccessory = 2;
                UW1.ExerciseId = 2;
                UW1.Difficulty = 4;
                db.Add(UW1);

                var UW2 = new UserWorkout();
                UW2.UserId = 3;
                UW2.WorkoutId = 4;
                UW2.AccessoryID = 3;
                UW2.ExerciseId = 3;
                UW2.Difficulty = 6;
                db.Add(UW2);

                var UW3 = new UserWorkout();
                UW3.UserId = 1;
                UW3.WorkoutId = 5;
                UW3.AccessoryID = 2;
                db.Add(UW3);

                var UW4 = new UserWorkout();
                UW4.UserId = 3;
                UW4.WorkoutId = 3;
                UW4.AccessoryID = 1;
                UW4.ExerciseId = 5;
                UW4.Difficulty = 8;
                db.Add(UW4);

                var UW5 = new UserWorkout();
                UW5.UserId = 3;
                UW5.WorkoutId = 1;
                UW5.AccessoryID = 1;
                UW5.ExtraAccessory = 2;
                UW5.ExerciseId = 4;
                UW5.Difficulty = 7;
                db.Add(UW5);

                var UW6 = new UserWorkout();
                UW6.UserId = 2;
                UW6.WorkoutId = 2;
                UW6.AccessoryID = 4;
                UW6.ExtraAccessory = 2;
                UW6.ExerciseId = 1;
                UW6.Difficulty = 5;
                db.Add(UW6);

                var UW7 = new UserWorkout();
                UW7.UserId = 1;
                UW7.WorkoutId = 4;
                UW7.AccessoryID = 3;
                UW7.ExerciseId = 3;
                UW7.Difficulty = 4;
                db.Add(UW7);

                var UW8 = new UserWorkout();
                UW8.UserId = 3;
                UW8.WorkoutId = 5;
                UW8.AccessoryID = 2;
                db.Add(UW8);

                var UW9 = new UserWorkout();
                UW9.UserId = 1;
                UW9.WorkoutId = 3;
                UW9.AccessoryID = 1;
                UW9.ExtraAccessory = 2;
                UW9.ExerciseId = 5;
                UW9.Difficulty = 9;
                db.Add(UW9);

                var UW10 = new UserWorkout();
                UW10.UserId = 3;
                UW10.WorkoutId = 2;
                UW10.AccessoryID = 4;
                UW10.ExerciseId = 2;
                UW10.Difficulty = 2;
                db.Add(UW10);

                db.SaveChanges();


            }
            //1.
            Console.WriteLine("\n\nQueries\n\n");
            Console.WriteLine("\n\n1.ALL USER, THEIR WORKOUTNAME AND USERWORKOUTID\n\n");
            using (var db = new WorkoutManagementContext())
            {
                var userWorkouts = db.UserWorkouts.OrderBy(UW => UW.user.FirstName).Include(UW => UW.user).Include(UW => UW.workout).ToList();
                foreach (var userworkout in userWorkouts)
                {
                    Console.WriteLine($"UserName: { userworkout.user.FirstName} {userworkout.user.LastName}");
                    
                    Console.WriteLine($"WorkoutName: {userworkout.workout.Name}");
                    Console.WriteLine("------");

                }

            }

           // 4.
            Console.WriteLine("\n\n4.Highest difficulty level with Exercise,Workout Name Details\n\n ");
            using (var db = new WorkoutManagementContext())
            {
                var userWorkouts = db.UserWorkouts.OrderByDescending(UW => UW.Difficulty).Include(UW => UW.user).
                    Include(UW => UW.workout).Include(UW => UW.exercise).ToList().First();

                Console.WriteLine($"UserWorkoutName:{userWorkouts.workout.Name}" +
                    $"\nUserFirstname: {userWorkouts.user.FirstName}," +
                    $"\nExerciseName: {userWorkouts.exercise.Name.ToString()} " +
                    $"\nDifficulty:{ userWorkouts.Difficulty.ToString()}");

            }
       

            //3. 
            Console.WriteLine("\n\n3.Displaying how many times each accessory is used\n\n"); //not fully completed
            using (var db = new WorkoutManagementContext())
            {
                var accessory = db.Accessories.ToList();
                int totalitems = accessory.Count();

                var userworkouts = db.UserWorkouts.OrderBy(UW => UW.AccessoryID).GroupBy(UW => UW.AccessoryID).ToList();

                int i = 1;
                foreach (var userworkout in userworkouts)
                {

                    Console.WriteLine($"AccessoryID {i}: Count: {userworkout.Count()} ");
                    i++;

                }
                using (var db1 = new WorkoutManagementContext())
                {
                    var eList = db1.Accessories.Where(
                        Accessory => !db1.UserWorkouts.Any(
                            we => we.AccessoryID == Accessory.AccessoryId)).
                            Select(Accessory => Accessory.AccessoryId).ToList();
                    

                    foreach (var e in eList)
                    {
                        Console.WriteLine($"AccessoryID {e}: Count: 0");
                    }
                }

            }

            //2. 
            Console.WriteLine("\n\n2. Accessory which is not used"); 
            using(var db=new WorkoutManagementContext())
            {
                var eList = db.Accessories.Where(
                    Accessory => !db.UserWorkouts.Any(
                        we => we.AccessoryID == Accessory.AccessoryId)).
                        Select(Accessory => Accessory.Name).ToList();
                Console.WriteLine("\n\nUnused Accessory:");

                foreach(var e in eList)
                {
                    Console.WriteLine(e);
                }
            }

        }
    }
}
