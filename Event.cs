using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02
{
    public class Event
    {
        public int Id{ get; set; }
        public string Title { get; set; } = string.Empty;
        public string Desc { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaximumNumberOfAttendees{ get; set; }
        public int OroginzerId { get; set; }
        public OrganizerClass Organizer{ get; set; } = null!;

    }
}
