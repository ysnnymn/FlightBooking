using AutoMapper;
using FllightBooking.Dtos.FlightDtos;
using FllightBooking.Entities;
using FllightBooking.Settings;
using MongoDB.Driver;

namespace FlightBooking.Services.FlightServices;

public class FlightService:IFlightService
{
    private readonly IMapper _mapper;
    private readonly IMongoCollection<Flight> _flightcollection;

    public FlightService(IMapper mapper,IDatabaseSettings _databaseSettings)
    {
        var client = new MongoClient(_databaseSettings.ConnectionString);
        var database = client.GetDatabase(_databaseSettings.DatabaseName);
        _flightcollection = database.GetCollection<Flight>(_databaseSettings.FlightCollectionName);
        _mapper = mapper;
    }

    public async Task<List<ResultFlightDto>> GetAllFlightsAsync()
    {
     var values= await _flightcollection.Find(x=>true).ToListAsync();
     return _mapper.Map<List<ResultFlightDto>>(values);
    }

    public async Task<GetFlightByIdDto> GetFlightByIdAsync(string id)
    {
       var value=await _flightcollection.Find(x=>x.FlightId == id).FirstOrDefaultAsync();
       return _mapper.Map<GetFlightByIdDto>(value);
    }

    public async Task CreateFlightAsync(CreateFlightDto createFlightDto)
    {
        var values=_mapper.Map<Flight>(createFlightDto);
        await _flightcollection.InsertOneAsync(values);
    }

    public async Task DeleteFlightAsync(string id)
    {
      await _flightcollection.DeleteOneAsync(z=>z.FlightId == id);
    }

    public  async Task UpdateFlightAsync(UpdateFlightDto updateFlightDto)
    {
        var value= _mapper.Map<Flight>(updateFlightDto);
        await   _flightcollection.FindOneAndReplaceAsync(z => z.FlightId == updateFlightDto.FlightId, value);
        
    }
}