package com.traffic.management;
import io.swagger.v3.oas.models.annotations.OpenAPI31;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@OpenAPI31
@SpringBootApplication
public class SmartTrafficManagementApplication {
	public static void main(String[] args) {
		SpringApplication.run(SmartTrafficManagementApplication.class, args);
	}
}