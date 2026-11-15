using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02
{
    public class BadgeClass
    {

        public enum BadgeTier
        {
            standard = 1,
            VIP = 2
        }

        public int BadgeId{ get; set; }
        public string BadgeNumber { get; set; } = string.Empty;
        public DateTime IssuedDate { get; set; }
        public BadgeTier Tier { get; set; }

        public int AttendeeId{ get; set; }
        public AttendeeClass Attendee { get; set; } = null!;
    }
}
