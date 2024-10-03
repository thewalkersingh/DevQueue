package com.traffic.management.controller;
import com.traffic.management.model.TrafficLight;
import com.traffic.management.repository.TrafficLightRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/traffic-lights")
public class TrafficLightController {
	@Autowired
	private TrafficLightRepository trafficLightRepository;
	
	@GetMapping
	public List<TrafficLight> getAllTrafficLights() {
		return trafficLightRepository.findAll();
	}
	
	@GetMapping("/{id}")
	public TrafficLight getTrafficLightById(@PathVariable Long id) {
		return trafficLightRepository.findById(id).orElse(null);
	}
	
	@PostMapping
	public TrafficLight createTrafficLight(@RequestBody TrafficLight trafficLight) {
		return trafficLightRepository.save(trafficLight);
	}
	
	@PutMapping("/{id}")
	public TrafficLight updateTrafficLight(@PathVariable Long id, @RequestBody TrafficLight trafficLight) {
		trafficLight.setId(id);
		return trafficLightRepository.save(trafficLight);
	}
	
	@DeleteMapping("/{id}")
	public void deleteTrafficLight(@PathVariable Long id) {
		trafficLightRepository.deleteById(id);
	}
}