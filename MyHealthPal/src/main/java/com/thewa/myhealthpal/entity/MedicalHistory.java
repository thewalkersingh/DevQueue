package com.thewa.myhealthpal.entity;
import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.time.LocalDate;

@Entity
@Data
@NoArgsConstructor
@AllArgsConstructor
public class MedicalHistory {
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;
	
	private String condition;
	private LocalDate diagnosisDate;
	
	@ManyToOne
	@JoinColumn(name = "patient_id")
	private Patient patient;
}