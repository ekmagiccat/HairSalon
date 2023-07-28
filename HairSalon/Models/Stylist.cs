namespace HairSalon.Models
{
    public class Stylist
    {
        public int StylistId { get; set; }
        public string Description { get; set; }
        public List<Stylist> Stylists { get; set; }
    }
}