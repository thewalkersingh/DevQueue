package com.traffic.management.controller;
import com.traffic.management.repository.IntersectionRepository;
import com.traffic.management.repository.SensorRepository;
import com.traffic.management.repository.TrafficLightRepository;
import com.traffic.management.repository.VehicleRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class HomeController {
	@Autowired
	private IntersectionRepository intersectionRepository;
	@Autowired
	private SensorRepository sensorRepository;
	@Autowired
	private TrafficLightRepository trafficLightRepository;
	@Autowired
	private VehicleRepository vehicleRepository;
	
	@GetMapping("/")
	public String home() {
		return "home";
	}
	
	//	@GetMapping("/dashboard")
//	public String dashboard(Model model) {
//		model.addAttribute("totalIntersections", intersectionRepository.count());
//		model.addAttribute("totalSensors", sensorRepository.count());
//		model.addAttribute("totalTrafficLights", trafficLightRepository.count());
//		model.addAttribute("totalVehicles", vehicleRepository.count());
//		return "dashboard";
//	}
//
//	@GetMapping("/traffic-details")
//	public String trafficDetails(Model model) {
//		List<Intersection> intersections = intersectionRepository.findAll();
//		List<Sensor> sensors = sensorRepository.findAll();
//		List<TrafficLight> trafficLights = trafficLightRepository.findAll();
//		List<Vehicle> vehicles = vehicleRepository.findAll();
//
//		model.addAttribute("intersections", intersections);
//		model.addAttribute("sensors", sensors);
//		model.addAttribute("trafficLights", trafficLights);
//		model.addAttribute("vehicles", vehicles);
//
//		return "traffic-details";
//	}
	@GetMapping("/dashboard")
	public String dashboard() {
		return "dashboard";
	}
	
	@GetMapping("/traffic-details")
	public String trafficDetails() {
		return "traffic-details";
	}
	
	@GetMapping("/intersections")
	public String intersections() {
		return "intersections";
	}
	
	@GetMapping("/sensors")
	public String sensors() {
		return "sensors";
	}
	
	@GetMapping("/traffic-lights")
	public String trafficLights() {
		return "traffic-lights";
	}
	
	@GetMapping("/vehicles")
	public String vehicles() {
		return "vehicles";
	}
	
	@GetMapping("/about")
	public String about() {
		return "about";
	}
}