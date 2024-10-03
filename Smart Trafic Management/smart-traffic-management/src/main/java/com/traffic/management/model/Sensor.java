package com.traffic.management.model;
import com.fasterxml.jackson.annotation.JsonBackReference;
import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity
@Data
@NoArgsConstructor
@AllArgsConstructor
public class Sensor {
	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	private Long id;
	private String location; // E.g., "3rd Ave, West Side"
	private int vehicleCount; // Number of vehicles detected by the sensor
	@ManyToOne
	@JoinColumn(name="intersection_id")
	@JsonBackReference
	private Intersection intersection;
}