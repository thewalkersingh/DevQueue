package com.traffic.management.repository;
import com.traffic.management.model.TrafficLight;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface TrafficLightRepository extends JpaRepository<TrafficLight, Long> {
	List<TrafficLight> findByIntersectionId(Long intersectionId);
}