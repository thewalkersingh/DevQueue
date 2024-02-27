using System.ComponentModel.DataAnnotations;

namespace RetroRidesAPI.Models;

public class Product
{
    public int Id { get; set; }

    [Required]
    public string ModelName { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public long Price { get; set; }

    [Required]
    public string ImageUrl { get; set; }

    [Required]
    public DateTime YearOfManufacture { get; set; }

    [Required]
    public string Manufacturer { get; set; }

    [Required]
    public int CurrentRun { get; set; }

    [Required]
    public int EngineDisplacement { get; set; }

}
