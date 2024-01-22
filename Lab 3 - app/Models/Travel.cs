using Microsoft.AspNetCore.Mvc;

namespace Lab_3___app.Models
{
    public class Travel
    {
        [HiddenInput]
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string StartingLocation { get; set; }
        public string EndingLocation { get; set; }
        public string Participants { get; set; }
        public string Guide { get; set; }
    }
}
