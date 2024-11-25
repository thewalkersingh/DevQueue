using HouseRatingApp.DTO;
using HouseRatingApp.Entities;
using HouseRatingApp.Repositories;

namespace HouseRatingApp.Services;

// Services/HouseService.cs
public class HouseService : IHouseService
{
    private readonly IHouseRepository _houseRepository;

    public HouseService(IHouseRepository houseRepository)
    {
        _houseRepository = houseRepository;
    }

    public IEnumerable<HouseDTO> GetAllHouses()
    {
        return _houseRepository.GetAll().Select(h => new HouseDTO
        {
            Id = h.Id,
            Address = h.Address,
            Description = h.Description,
            Rating = h.Rating
        }).ToList();
    }

    public HouseDTO GetHouseById(int id)
    {
        var house = _houseRepository.GetById(id);
        if (house == null)
            return null;

        return new HouseDTO
        {
            Id = house.Id,
            Address = house.Address,
            Description = house.Description,
            Rating = house.Rating
        };
    }

    public void AddHouse(HouseDTO houseDto)
    {
        var house = new House
        {
            Address = houseDto.Address,
            Description = houseDto.Description,
            Rating = houseDto.Rating
        };
        _houseRepository.Add(house);
    }

    public void UpdateHouse(HouseDTO houseDto)
    {
        var house = new House
        {
            Id = houseDto.Id,
            Address = houseDto.Address,
            Description = houseDto.Description,
            Rating = houseDto.Rating
        };
        _houseRepository.Update(house);
    }

    public void DeleteHouse(int id)
    {
        _houseRepository.Delete(id);
    }
}

