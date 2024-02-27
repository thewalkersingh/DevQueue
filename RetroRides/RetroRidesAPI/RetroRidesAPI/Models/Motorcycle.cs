using System;
using System.ComponentModel.DataAnnotations;

namespace RetroRidesAPI.Models;

public class Motorcycle : Product
{
    [Required]
    public string BrakeSystem { get; set; }

    [Required]
    public bool ABS { get; set; }

    [Required]
    public string Transmission { get; set; }

    [Required]
    public bool BluetoothConnectivity { get; set; }
}
