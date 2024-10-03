package com.traffic.management.repository;
import com.traffic.management.model.Sensor;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface SensorRepository extends JpaRepository<Sensor, Long> {
	// Custom method to find sensors by intersection
	List<Sensor> findByIntersectionId(Long intersectionId);
}