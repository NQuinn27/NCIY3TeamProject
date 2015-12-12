using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineConsult.Models
{
    public class ICD10
    {
        public int ID { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string additional { get; set; }
    }
}