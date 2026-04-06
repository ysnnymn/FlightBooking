using AutoMapper;
using FllightBooking.Dtos.FlightDtos;
using FllightBooking.Entities;

namespace FllightBooking.Mapping;

public class GeneralMapping:Profile
{
    public GeneralMapping()
    {
        CreateMap<Flight,CreateFlightDto>().ReverseMap();
        CreateMap<Flight,GetFlightByIdDto>().ReverseMap();
        CreateMap<Flight,ResultFlightDto>().ReverseMap();
        CreateMap<Flight,UpdateFlightDto>().ReverseMap();
    }
    
}