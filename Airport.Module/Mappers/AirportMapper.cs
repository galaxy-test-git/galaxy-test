namespace Airport.Module.Mappers
{
    using Abstract.DTO;
    using AirportModel = BusinessObjects.Structure.Airport;

    public class AirportMapper: BaseMapper
    {
        public object Map(AirportModel source) => Mapper.Map<AirportModel, Airport>(source);
    }
}
