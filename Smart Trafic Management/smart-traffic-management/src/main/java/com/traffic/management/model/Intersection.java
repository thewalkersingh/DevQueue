package com.traffic.management.model;
import com.fasterxml.jackson.annotation.JsonManagedReference;
import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.util.List;

@Entity
@Data
@NoArgsConstructor
@AllArgsConstructor
public class Intersection {
	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	private Long id;
	private String name; // E.g., "Main St & 3rd Ave"
	@OneToMany(mappedBy="intersection", cascade=CascadeType.ALL)
	@JsonManagedReference
	private List<TrafficLight> trafficLights;
	@OneToMany(mappedBy="intersection", cascade=CascadeType.ALL)
	@JsonManagedReference
	private List<Sensor> sensors;
}