using AutoMapper;
using distributed_calculator.Models.DTOs;
using eventbus.Events;

namespace webapi.Models.Mapper {
    public class MapperProfiles : Profile {
        public MapperProfiles() {
            CreateMap<OperationDTO, OperationEvent>().ReverseMap();
        }
    }
}
