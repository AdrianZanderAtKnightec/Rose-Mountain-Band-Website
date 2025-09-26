using Microsoft.CodeAnalysis.Editing;
using RoseMountainBandWebsite.Models;

namespace RoseMountainBandWebsite.ViewModel
{
    public class TourConcertViewModel
    {
        public List<Tour> Tours { get; set; }
        public List<List<Concert>> Concerts { get; set; }
        public Tour NewTour { get; set; }
        public Concert NewConcert { get; set; }

    }
}
