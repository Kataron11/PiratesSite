using System.Collections.Generic;

namespace Project6.Model
{
    public class Boat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int MaxCrew { get; set; }
        public int MinCrew { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public int CanonAmount { get; set; }

        public virtual ICollection<AccountBoat> AccountBoats { get; set; }

    }
}
