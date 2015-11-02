using System;
using OnlineConsult.Enums;
using System.ComponentModel.DataAnnotations;
using System.Threading;

namespace OnlineConsult.Models
{
    public class Patient
    {
        [Key]
        public Guid UID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public DateTime dateOfBirth { get; set; }
        public DateTime signupDate { get; set; }
        public Gender gender { get; set; }

        public Patient() {
            this.UID = Guid.NewGuid();
        }

        public Patient(string firstName, string lastName, string email, DateTime dateOfBirth, Gender gender)
        {
            this.UID = Guid.NewGuid();
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.dateOfBirth = dateOfBirth;
            this.signupDate = DateTime.Today;
            this.gender = gender;
        }

    }
}