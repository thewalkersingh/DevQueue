using HouseRatingApp.Entities;
// Repositories/HouseRepository.cs
using HouseRatingApp.Data;

namespace HouseRatingApp.Repositories;

public class HouseRepository : IHouseRepository
{
    private readonly AppDbContext _context;

    public HouseRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<House> GetAll()
    {
        return _context.Houses.ToList();
    }

    public House GetById(int id)
    {
        return _context.Houses.Find(id);
    }

    public void Add(House house)
    {
        _context.Houses.Add(house);
        _context.SaveChanges();
    }

    public void Update(House house)
    {
        _context.Houses.Update(house);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var house = _context.Houses.Find(id);
        if (house != null)
        {
            _context.Houses.Remove(house);
            _context.SaveChanges();
        }
    }
}


