### Database Schema

* 1.1 TrafficLight
    * Description: Represents traffic lights at various locations.
    * Attributes:
        * id: Long (Primary Key)
        * location: String (Location of the traffic light)
        * state: String (State of the traffic light, e.g., RED, GREEN, YELLOW)

* 1.2 Vehicle
    * Description: Represents vehicles monitored in the system.
    * Attributes:
        * id: Long (Primary Key)
        * licensePlate: String (License plate of the vehicle)
        * status: String (Status of the vehicle, e.g., MOVING, STOPPED)

* 1.3 TrafficReport
    * Description: Represents reports on traffic conditions.
    * Attributes:
        * id: Long (Primary Key)
        * reportDate: String (Date of the report)
        * location: String (Location of the reported traffic condition)
        * details: String (Description of the traffic situation)

* 1.4 Intersection
    * Description: Represents intersections where traffic lights are managed.
    * Attributes:
        * id: Long (Primary Key)
        * name: String (Name of the intersection)
        * location: String (Location of the intersection)

### Repositories

* 2.1 TrafficLightRepository
    * Description: Repository interface for managing TrafficLight entities.
    * Methods:
        * findAll(): Retrieve all traffic lights
        * findById(Long id): Retrieve a specific traffic light by ID
        * save(TrafficLight trafficLight): Save or update a traffic light
        * deleteById(Long id): Delete a traffic light by ID
* 2.2 VehicleRepository
    * Description: Repository interface for managing Vehicle entities.
    * Methods:
        * findAll(): Retrieve all vehicles
        * findById(Long id): Retrieve a specific vehicle by ID
        * save(Vehicle vehicle): Save or update a vehicle
        * deleteById(Long id): Delete a vehicle by ID
* 2.3 TrafficReportRepository
    * Description: Repository interface for managing TrafficReport entities.
    * Methods:
        * findAll(): Retrieve all traffic reports
        * findById(Long id): Retrieve a specific traffic report by ID
        * save(TrafficReport trafficReport): Save or update a traffic report
        * deleteById(Long id): Delete a traffic report by ID
* 2.4 IntersectionRepository
    * Description: Repository interface for managing Intersection entities.
    * Methods:
        * findAll(): Retrieve all intersections
        * findById(Long id): Retrieve a specific intersection by ID
        * save(Intersection intersection): Save or update an intersection
        * deleteById(Long id): Delete an intersection by ID