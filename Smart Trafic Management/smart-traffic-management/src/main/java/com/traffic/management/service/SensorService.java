package com.traffic.management.service;
import com.traffic.management.model.Sensor;
import com.traffic.management.repository.SensorRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class SensorService {
	private final SensorRepository sensorRepository;
	
	public SensorService(SensorRepository sensorRepository) {
		this.sensorRepository = sensorRepository;
	}
	
	public List<Sensor> getSensorsByIntersection(Long intersectionId) {
		return sensorRepository.findByIntersectionId(intersectionId);
	}
	
	public Sensor addSensor(Sensor sensor) {
		return sensorRepository.save(sensor);
	}
	
	public Sensor updateSensor(Long id, Sensor updatedSensor) {
		return sensorRepository.findById(id)
		                       .map(sensor -> {
			                       sensor.setVehicleCount(updatedSensor.getVehicleCount());
			                       return sensorRepository.save(sensor);
		                       })
		                       .orElseThrow(() -> new IllegalArgumentException("Sensor not found!"));
	}
	
	public void deleteSensor(Long id) {
		sensorRepository.deleteById(id);
	}
}