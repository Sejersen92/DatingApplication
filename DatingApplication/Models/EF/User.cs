using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public DateTime CreateDate { get; set; }
        public Message[] Messages { get; set; }
    }
}