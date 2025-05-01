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
        public Event(int id, string name, string description, DateTime date, string location, int attendeesCount)
        {
            Id = id;
            Name = name;
            Description = description;
            Date = date;
            Location = location;
            AttendeesCount = attendeesCount;
        }
    }
}
