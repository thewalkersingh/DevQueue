package com.traffic.management.service;
import com.traffic.management.model.TrafficLight;
import com.traffic.management.repository.TrafficLightRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class TrafficLightService {
	private final TrafficLightRepository trafficLightRepository;
	
	public TrafficLightService(TrafficLightRepository trafficLightRepository) {
		this.trafficLightRepository = trafficLightRepository;
	}
	
	public List<TrafficLight> getTrafficLightsByIntersection(Long intersectionId) {
		return trafficLightRepository.findByIntersectionId(intersectionId);
	}
	
	public TrafficLight addTrafficLight(TrafficLight trafficLight) {
		return trafficLightRepository.save(trafficLight);
	}
	
	public TrafficLight updateTrafficLightStatus(Long id, TrafficLight updatedLight) {
		return trafficLightRepository.findById(id).map(trafficLight -> {
			trafficLight.setStatus(updatedLight.getStatus());
			return trafficLightRepository.save(trafficLight);
		}).orElseThrow(() -> new IllegalArgumentException("Traffic light not found!"));
	}
	
	public void deleteTrafficLight(Long id) {
		trafficLightRepository.deleteById(id);
	}
}