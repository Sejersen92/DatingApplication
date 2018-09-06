using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatingApplication.Models
{
    public class Profile
    {
        public string picture { get; set; }
        public User User { get; set; }
        public string Description { get; set; }

    }
}