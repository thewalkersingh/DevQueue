using HouseRatingApp.Entities;

namespace HouseRatingApp.Repositories;

// Repositories/IHouseRepository.cs
public interface IHouseRepository
{
    IEnumerable<House> GetAll();
    House GetById(int id);
    void Add(House house);
    void Update(House house);
    void Delete(int id);
}
