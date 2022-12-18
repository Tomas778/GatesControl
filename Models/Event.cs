using System;

namespace GatesControl.Models
{
    public class Event
    {
        public int Id { get; private set; }
        public DateTime TriggerTime { get; set; }
        public string Action { get; set; }  //In, Out or x - fail attempt
        public bool SuccessEvent { get; set; } // TRUE -success, FALSE - no

        public int WorkerId { get; private set; }
        public Worker Worker { get; set; }
        public int GateId { get; private set; }
        public Gate Gate { get; set; }

    }
}
