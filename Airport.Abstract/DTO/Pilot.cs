namespace Airport.Abstract.DTO
{
    using System.Collections.Generic;

    public class Pilot: BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Airport Airport { get; set; }

        public IEnumerable<Aircraft> Aircrafts { get; set; }

        public int CountAircraft { get; set; }
    }
}
