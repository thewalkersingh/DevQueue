#### REST API Endpoints

5.1 TrafficLightController
Base URL: /api/traffic-lights

GET /api/traffic-lights

Description: Retrieve all traffic lights
Response: List of TrafficLight objects
GET /api/traffic-lights/{id}

Description: Retrieve a specific traffic light by ID
Response: TrafficLight object
POST /api/traffic-lights

Description: Create a new traffic light
Request Body: TrafficLight object
Response: Created TrafficLight object
PUT /api/traffic-lights/{id}

Description: Update an existing traffic light
Request Body: Updated TrafficLight object
Response: Updated TrafficLight object
DELETE /api/traffic-lights/{id}

Description: Delete a traffic light by ID
Response: No content
5.2 VehicleController
Base URL: /api/vehicles

GET /api/vehicles

Description: Retrieve all vehicles
Response: List of Vehicle objects
GET /api/vehicles/{id}

Description: Retrieve a specific vehicle by ID
Response: Vehicle object
POST /api/vehicles

Description: Create a new vehicle
Request Body: Vehicle object
Response: Created Vehicle object
PUT /api/vehicles/{id}

Description: Update an existing vehicle
Request Body: Updated Vehicle object
Response: Updated Vehicle object
DELETE /api/vehicles/{id}

Description: Delete a vehicle by ID
Response: No content
5.3 TrafficReportController
Base URL: /api/traffic-reports

GET /api/traffic-reports

Description: Retrieve all traffic reports
Response: List of TrafficReport objects
GET /api/traffic-reports/{id}

Description: Retrieve a specific traffic report by ID
Response: TrafficReport object
POST /api/traffic-reports

Description: Create a new traffic report
Request Body: TrafficReport object
Response: Created TrafficReport object
PUT /api/traffic-reports/{id}

Description: Update an existing traffic report
Request Body: Updated TrafficReport object
Response: Updated TrafficReport object
DELETE /api/traffic-reports/{id}

Description: Delete a traffic report by ID
Response: No content
5.4 IntersectionController
Base URL: /api/intersections

GET /api/intersections

Description: Retrieve all intersections
Response: List of Intersection objects
GET /api/intersections/{id}

Description: Retrieve a specific intersection by ID
Response: Intersection object
POST /api/intersections

Description: Create a new intersection
Request Body: Intersection object
Response: Created Intersection object
PUT /api/intersections/{id}

Description: Update an existing intersection
Request Body: Updated Intersection object
Response: Updated Intersection object
DELETE /api/intersections/{id}

Description: Delete an intersection by ID
Response: No content