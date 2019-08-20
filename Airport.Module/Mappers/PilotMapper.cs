namespace Airport.Module.Mappers
{
    using Abstract.DTO;
    using PilotModel = BusinessObjects.Structure.Pilot;

    public class PilotMapper : BaseMapper
    {
        public Pilot Map(PilotModel source) => Mapper.Map<PilotModel, Pilot>(source);
    }
}
