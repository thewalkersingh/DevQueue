using System;
using System.ComponentModel.DataAnnotations;

namespace RetroRidesAPI.Models;

public class Car : Product
{
    [Required]
    public string Transmission { get; set; }

    [Required]
    public string DriveType { get; set; }

    [Required]
    public string CarType { get; set; }

    public int SeatingCapacity { get; set; }

    public bool AlloyWheels { get; set; }

    public bool EntertainmentSystem { get; set; }

    public bool NavigationSystem { get; set; }

    public bool AirConditioning { get; set; }
}
