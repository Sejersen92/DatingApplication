using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatingApplication.Models
{
    public class ProtoProfile
    {
        public int ID { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public User User { get; set; }

        #region DatingStuff

        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public string Gender { get; set; }
        public string BodyType { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public int User_ID { get; set; }

        #endregion DatingStuff

    }
}