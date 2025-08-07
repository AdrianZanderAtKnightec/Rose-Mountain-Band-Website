namespace RoseMountainBandWebsite.Models
{
    public class Concert
    {
        public int TourId { get; set; }
        public String Location { get; set; }
        public DateTime Date { get; set; }
        public String Description { get; set; }

        public Concert() { 
            
        }
    }
}
