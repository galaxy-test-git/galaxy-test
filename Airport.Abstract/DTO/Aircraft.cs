namespace Airport.Abstract.DTO
{
    using System.Collections.Generic;

    public class Aircraft: BaseEntity
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public Airport Airport { get; set; }

        public ICollection<Pilot> Pilots { get; set; }
    }
}
