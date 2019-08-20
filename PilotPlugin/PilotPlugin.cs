namespace PilotPlugin
{
    using System.Linq;
    using Airport.Abstract.DTO;

    public class PilotPlugin
    {
        public bool Checks(Pilot pilot)
        {
            return pilot.Aircrafts.Any();
        }
    }
}
