package com.traffic.management.config;
import com.traffic.management.model.*;
import com.traffic.management.repository.IntersectionRepository;
import com.traffic.management.repository.SensorRepository;
import com.traffic.management.repository.TrafficLightRepository;
import com.traffic.management.repository.VehicleRepository;
import org.springframework.boot.CommandLineRunner;
import org.springframework.context.annotation.Bean;
import org.springframework.stereotype.Component;

import java.util.Arrays;

@Component
public class DataLoader {
	@Bean
	public CommandLineRunner loadData(
			IntersectionRepository intersectionRepository,
			SensorRepository sensorRepository,
			TrafficLightRepository trafficLightRepository,
			VehicleRepository vehicleRepository) {
		return args -> {
			// Create Intersections
			Intersection intersection1 = new Intersection(null, "Main St & 3rd Ave", null, null);
			Intersection intersection2 = new Intersection(null, "2nd Ave & 4th St", null, null);
			
			// Save Intersections
			intersectionRepository.saveAll(Arrays.asList(intersection1, intersection2));
			
			// Create and Save Sensors
			Sensor sensor1 = new Sensor(null, "3rd Ave, West Side", 15, intersection1);
			Sensor sensor2 = new Sensor(null, "2nd Ave, North Side", 22, intersection2);
			sensorRepository.saveAll(Arrays.asList(sensor1, sensor2));
			
			// Create and Save Traffic Lights
			TrafficLight trafficLight1 = new TrafficLight(null, "Main St & 3rd Ave", LightStatus.RED, intersection1);
			TrafficLight trafficLight2 = new TrafficLight(null, "2nd Ave & 4th St", LightStatus.GREEN, intersection2);
			trafficLightRepository.saveAll(Arrays.asList(trafficLight1, trafficLight2));
			
			// Create and Save Vehicles
			Vehicle vehicle1 = new Vehicle(null, VehicleType.PUBLIC, "ABC123");
			Vehicle vehicle2 = new Vehicle(null, VehicleType.PRIVATE, "XYZ789");
			vehicleRepository.saveAll(Arrays.asList(vehicle1, vehicle2));
		};
	}
}