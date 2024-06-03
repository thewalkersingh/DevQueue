using HouseRatingApp.DTO;

namespace HouseRatingApp.Services;

// Services/IHouseService.cs
public interface IHouseService
{
    IEnumerable<HouseDTO> GetAllHouses();
    HouseDTO GetHouseById(int id);
    void AddHouse(HouseDTO houseDto);
    void UpdateHouse(HouseDTO houseDto);
    void DeleteHouse(int id);
}

