using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals_C_.Model
{
    internal class Participants
    {
        public int ParticipantID { get; set; }

        public string ParticipantName{ get; set; }

        public string ParticipantType { get; set; }
        public AdoptionEvents Events { get; set; }

        public Participants()
        {
            Events = new AdoptionEvents();
        }

    }
}
