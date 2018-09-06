using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatingApplication.Models
{
    public class Message
    {
        public User From { get; set; }
        public User To { get; set; }
        public DateTime date { get; set; }
        public string body { get; set; }
    }
}