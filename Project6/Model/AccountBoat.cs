

namespace Project6.Model
{
    public class AccountBoat
    {
        public int Id { get; set; }
        public int CrewAmount { get; set; }
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
        public int BoatId { get; set; }
        public virtual Boat Boat { get; set;  }
    }
}
