namespace RoseMountainBandWebsite.Models
{
    public class Message
    {
        public int Id { get; set; }
        public String SubmitterName { get; set; }
        public String SubmitterEmail { get; set; }
        public String SubmittedText { get; set; }

        public Message()
        {

        }
    }
}
