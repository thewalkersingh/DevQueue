package com.traffic.management.repository;
import com.traffic.management.model.Intersection;
import org.springframework.data.jpa.repository.JpaRepository;

public interface IntersectionRepository extends JpaRepository<Intersection, Long> {}