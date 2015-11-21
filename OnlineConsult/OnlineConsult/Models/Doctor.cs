using System;
using OnlineConsult.Enums;
using System.ComponentModel.DataAnnotations;

namespace OnlineConsult.Models
{
    public class Doctor
    {
        [Key]
        public Guid UID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName
        {
            get
            {
                return String.Format("{0} {1}",firstName,lastName);
            }
        }
        public string email { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime signupDate { get; set; }
        public string qualifications { get; set; }

        public Doctor()
        {
            UID = Guid.NewGuid();
        }
    }
}