using System.Collections.Generic;

namespace GatesControl.Models
{
    public class Worker
    {
        public int Id { get; private set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public ICollection<Gate> Gates { get; set; }
    }
}
