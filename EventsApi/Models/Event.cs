namespace EventsApi.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int AttendeesCount { get; set; }
        // Constructor
        public Event()
        {
        }
    }
}
