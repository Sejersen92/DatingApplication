using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatingApplication.Models
{
    public class User
    {
        public int ID { get; set; }
        public string LoginName { get; set; }
        public string PassCode { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime CreatingDate { get; set; }
        public Profile Profile { get; set; }
        public Message[] Messages { get; set; }
    }
}