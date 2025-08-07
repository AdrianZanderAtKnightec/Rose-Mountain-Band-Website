using Microsoft.CodeAnalysis.Editing;
using RoseMountainBandWebsite.Models;

namespace RoseMountainBandWebsite.ViewModel
{


    public class TourConcertViewModel
    {
        public List<Tour> PreviouslySubmittedTours;
        public Tour SubmittedTour { get; set; }
        public Concert SubmittedToursConcert { get; set; }

        public TourConcertViewModel(List<Tour> PreviouslySubmittedTours, Concert SubmittedToursConcert)
        {
            this.PreviouslySubmittedTours = PreviouslySubmittedTours;
            this.SubmittedToursConcert = SubmittedToursConcert;
        }
    }
}
