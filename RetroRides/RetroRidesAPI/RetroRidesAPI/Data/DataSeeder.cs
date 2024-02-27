using Microsoft.EntityFrameworkCore;
using RetroRidesAPI.Models;

namespace RetroRidesAPI.Data;
public static class DataSeeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                ModelName = "Sample Product 1",
                Description = "This is a sample product description.",
                Price = 1000,
                ImageUrl = "sample-image-url-1.jpg",
                YearOfManufacture = DateTime.UtcNow.AddYears(-5),
                Manufacturer = "Sample Manufacturer",
                CurrentRun = 5621,
                EngineDisplacement = 150,
            },
            new Product
            {
                Id = 2,
                ModelName = "Sample Product 2",
                Description = "This is another sample product description.",
                Price = 1500,
                ImageUrl = "sample-image-url-2.jpg",
                YearOfManufacture = DateTime.UtcNow.AddYears(-3),
                Manufacturer = "Another Manufacturer",
                CurrentRun = 780,
                EngineDisplacement = 250,
            }
            // Add more dummy data for Products
        );

        modelBuilder.Entity<Car>().HasData(
            new Car
            {
                Id = 3,
                ModelName = "Sample Car 1",
                Description = "This is a sample car description.",
                Price = 20000,
                ImageUrl = "sample-car-image-1.jpg",
                YearOfManufacture = DateTime.UtcNow.AddYears(-2),
                Manufacturer = "Car Manufacturer",
                CurrentRun = 4000,
                EngineDisplacement = 2000,
                Transmission = "Automatic",
                DriveType = "Front-Wheel Drive",
                CarType = "Sedan",
                SeatingCapacity = 5,
                AlloyWheels = true,
                EntertainmentSystem = true,
                NavigationSystem = true,
                AirConditioning = true,
            },
            new Car
            {
                Id = 4,
                ModelName = "Sample Car 2",
                Description = "This is another sample car description.",
                Price = 25000,
                ImageUrl = "sample-car-image-2.jpg",
                YearOfManufacture = DateTime.UtcNow.AddYears(-1),
                Manufacturer = "Another Car Manufacturer",
                CurrentRun = 50000,
                EngineDisplacement = 1800,
                Transmission = "Manual",
                DriveType = "Rear-Wheel Drive",
                CarType = "Hatchback",
                SeatingCapacity = 4,
                AlloyWheels = true,
                EntertainmentSystem = true,
                NavigationSystem = false,
                AirConditioning = true,
            }
            // Add more dummy data for Cars
        );

        modelBuilder.Entity<Motorcycle>().HasData(
            new Motorcycle
            {
                Id = 5,
                ModelName = "Sample Motorcycle 1",
                Description = "This is a sample motorcycle description.",
                Price = 8000,
                ImageUrl = "sample-motorcycle-image-1.jpg",
                YearOfManufacture = DateTime.UtcNow.AddYears(-3),
                Manufacturer = "Motorcycle Manufacturer",
                CurrentRun = 12000,
                EngineDisplacement = 1000,
                Transmission = "Manual",
                BrakeSystem = "Disc",
                ABS = true,
                BluetoothConnectivity = false,
            },
            new Motorcycle
            {
                Id = 6,
                ModelName = "Sample Motorcycle 2",
                Description = "This is another sample motorcycle description.",
                Price = 6000,
                ImageUrl = "sample-motorcycle-image-2.jpg",
                YearOfManufacture = DateTime.UtcNow.AddYears(-2),
                Manufacturer = "Another Motorcycle Manufacturer",
                CurrentRun = 5000,
                EngineDisplacement = 750,
                Transmission = "Manual",
                BrakeSystem = "Drum",
                ABS = false,
                BluetoothConnectivity = true,
            }
            // Add more dummy data for Motorcycles
        );
    }
}
