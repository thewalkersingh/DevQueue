package com.traffic.management.service;
import com.traffic.management.model.Intersection;
import com.traffic.management.repository.IntersectionRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class IntersectionService {
	private final IntersectionRepository intersectionRepository;
	
	public IntersectionService(IntersectionRepository intersectionRepository) {
		this.intersectionRepository = intersectionRepository;
	}
	
	public List<Intersection> getAllIntersections() {
		return intersectionRepository.findAll();
	}
	
	public Intersection addIntersection(Intersection intersection) {
		return intersectionRepository.save(intersection);
	}
	
	public void deleteIntersection(Long id) {
		intersectionRepository.deleteById(id);
	}
}