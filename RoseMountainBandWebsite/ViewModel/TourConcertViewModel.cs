using Microsoft.CodeAnalysis.Editing;
using RoseMountainBandWebsite.Models;

namespace RoseMountainBandWebsite.ViewModel
{


    public class TourConcertViewModel
    {
        public List<Tour> PreviouslySubmittedTours { get; set; }
        public Tour SubmittedTour { get; set; }
        public Concert SubmittedToursConcert { get; set; }

        public TourConcertViewModel()
        {

        }

        /*
        public TourConcertViewModel(List<Tour> PreviouslySubmittedTours)
        {
            this.PreviouslySubmittedTours = PreviouslySubmittedTours;
        }

        public TourConcertViewModel(Tour SubmittedTour)
        {
            this.SubmittedTour = SubmittedTour;
        }

        public TourConcertViewModel(Concert SubmittedToursConcert)
        {
            this.SubmittedToursConcert = SubmittedToursConcert;
        }
        */
    }
}
