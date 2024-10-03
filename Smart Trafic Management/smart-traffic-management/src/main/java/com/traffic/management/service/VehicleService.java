package com.traffic.management.service;
import com.traffic.management.model.Vehicle;
import com.traffic.management.repository.VehicleRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class VehicleService {
	private final VehicleRepository vehicleRepository;
	
	public VehicleService(VehicleRepository vehicleRepository) {
		this.vehicleRepository = vehicleRepository;
	}
	
	public List<Vehicle> getAllVehicles() {
		return vehicleRepository.findAll();
	}
	
	public Vehicle addVehicle(Vehicle vehicle) {
		return vehicleRepository.save(vehicle);
	}
	
	public void deleteVehicle(Long id) {
		vehicleRepository.deleteById(id);
	}
}