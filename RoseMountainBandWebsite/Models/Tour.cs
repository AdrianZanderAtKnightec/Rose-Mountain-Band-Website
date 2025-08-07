using System;

namespace RoseMountainBandWebsite.Models
{
    public class Tour
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public Tour() {

        }

    }
}
