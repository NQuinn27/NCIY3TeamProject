using System;
using OnlineConsult.Enums;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace OnlineConsult.Models
{
    public class Patient
    {
        static int nextId;

        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        [Key]
        public string email { get; set; }
        public DateTime dateOfBirth { get; set; }
        public DateTime signupDate { get; set; }
        public Gender gender { get; set; }

        public Patient() {
            this.ID = Interlocked.Increment(ref nextId);
        }

        public Patient(string firstName, string lastName, string email, DateTime dateOfBirth, Gender gender)
        {
            this.ID = Interlocked.Increment(ref nextId);
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.dateOfBirth = dateOfBirth;
            this.signupDate = DateTime.Today;
            this.gender = gender;
        }

    }
}