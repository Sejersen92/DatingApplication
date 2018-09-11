using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DatingApplication.Models
{
    public class Profile
    {
        public int ID { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public User User { get; set; }

    }
}