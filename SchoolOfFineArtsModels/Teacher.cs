﻿using System.ComponentModel.DataAnnotations;

namespace SchoolOfFineArtsModels
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required, Range(1,130)]
        public int Age { get; set; }

        public virtual List<Course> Courses { get; set; } = new List<Course>();
        
        


        //override equals to take in an object and compare to teacher

        public override string ToString()
        {
            return $" ID: {Id}, First Name: {FirstName}, Last Name: {LastName}, Age: {Age} ";
        }
    }
}