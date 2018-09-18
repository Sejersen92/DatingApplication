namespace DatingApplication.Models
{
    public class Profile
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

        #endregion DatingStuff

    }
}