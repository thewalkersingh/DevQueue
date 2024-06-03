using HouseRatingApp.DTO;
using HouseRatingApp.Models;
using HouseRatingApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace HouseRatingApp.Controllers;

// Controllers/HouseController.cs
public class HouseController : Controller
{
    private readonly IHouseService _houseService;

    public HouseController(IHouseService houseService)
    {
        _houseService = houseService;
    }

    public IActionResult Index()
    {
        var houses = _houseService.GetAllHouses();
        return View(houses);
    }

    public IActionResult Details(int id)
    {
        var house = _houseService.GetHouseById(id);
        if (house == null)
            return NotFound();

        return View(house);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(HouseModel model)
    {
        if (ModelState.IsValid)
        {
            var houseDto = new HouseDTO
            {
                Address = model.Address,
                Description = model.Description,
                Rating = model.Rating
            };
            _houseService.AddHouse(houseDto);
            return RedirectToAction(nameof(Index));
        }
        return View(model);
    }

    public IActionResult Edit(int id)
    {
        var house = _houseService.GetHouseById(id);
        if (house == null)
            return NotFound();

        var model = new HouseModel
        {
            Id = house.Id,
            Address = house.Address,
            Description = house.Description,
            Rating = house.Rating
        };
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(HouseModel model)
    {
        if (ModelState.IsValid)
        {
            var houseDto = new HouseDTO
            {
                Id = model.Id,
                Address = model.Address,
                Description = model.Description,
                Rating = model.Rating
            };
            _houseService.UpdateHouse(houseDto);
            return RedirectToAction(nameof(Index));
        }
        return View(model);
    }

    public IActionResult Delete(int id)
    {
        var house = _houseService.GetHouseById(id);
        if (house == null)
            return NotFound();

        return View(house);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        _houseService.DeleteHouse(id);
        return RedirectToAction(nameof(Index));
    }
}

