namespace TicketsAPI.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string ShortDescription { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateTime CreatedDate { get; set; }
        public string Severity { get; set; } = default!;
        public DateTime TargetDate { get; set; }
        public string Status { get; set; } = default!;
    }
}
