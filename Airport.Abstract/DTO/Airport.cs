namespace Airport.Abstract.DTO
{
    using System.Collections.Generic;

    public class Airport: BaseEntity
    {
        public string Name { get; set; }

        IEnumerable<Pilot> Pilots { get; set; }

        IEnumerable<Aircraft> Aircraft { get; set; }
    }
}
