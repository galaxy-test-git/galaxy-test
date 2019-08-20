namespace Airport.Module.Mappers
{
    using AircraftModel = BusinessObjects.Structure.Aircraft;
    using Abstract.DTO;

    public class AircraftMapper : BaseMapper
    {
        public object Map(AircraftModel source) => Mapper.Map<AircraftModel, Aircraft>(source);
    }
}
