using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineConsult.Models
{
    public class Message
    {
        public int ID { get; set; }
        public Guid senderID { get; set; }
        public Guid recieverID { get; set; }
        public Boolean read { get; set; }
        public DateTime sentAt { get; set; }
        public Guid consultId { get; set; }
        public string text { get; set; }

    }
}