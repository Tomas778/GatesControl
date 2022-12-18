using System.Collections.Generic;

namespace GatesControl.Models
{
    public class Gate
    {
        public int Id { get; private set; }

        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<Worker> Workers { get; set; }

        public Gate()
        {
        }
    }
}
