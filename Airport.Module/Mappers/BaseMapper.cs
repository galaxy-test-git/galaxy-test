namespace Airport.Module.Mappers
{
    using System;
    using AutoMapper;
    using Abstract.DTO;
    using PilotModel = BusinessObjects.Structure.Pilot;
    using AircraftModel = BusinessObjects.Structure.Aircraft;
    using AirportModel = BusinessObjects.Structure.Airport;

    public class BaseMapper
    {
        protected IMapper Mapper { get; set; }

        public BaseMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PilotModel, Pilot>();
                cfg.CreateMap<AircraftModel, Aircraft>();
                cfg.CreateMap<AirportModel, Airport>();
            });

            Mapper = config.CreateMapper();
        }

        public object GetData(object data)
        {
            if (data is PilotModel)
                return new PilotMapper().Map((PilotModel)data);

            if (data is AircraftModel)
                return new AircraftMapper().Map((AircraftModel)data);

            if (data is AirportModel)
                return new AirportMapper().Map((AirportModel)data);

            throw new Exception("Type not found");
        }
    }
}
