using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02
{
    public class OrgnizerProfileClass
    {
        public int Id { get; set; }
        public string? Biography { get; set; }
        public string? Link { get; set; }
        public string? logo{ get; set; }  
        public int OroginzerId { get; set; }

        public OrganizerClass Organizer { get; set; } = null!;
    }
}
