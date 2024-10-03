package com.traffic.management.model;
import com.fasterxml.jackson.annotation.JsonBackReference;
import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity(name="trafficLight")
@Data
@NoArgsConstructor
@AllArgsConstructor
public class TrafficLight {
	@Id
	@GeneratedValue(strategy=GenerationType.IDENTITY)
	private Long id;
	private String location; // E.g., "Main St & 3rd Ave"
	@Enumerated(EnumType.STRING)
	private LightStatus status; // Red, Yellow, Green
	@ManyToOne
	@JoinColumn(name="intersection_id")
	@JsonBackReference
	private Intersection intersection;
}