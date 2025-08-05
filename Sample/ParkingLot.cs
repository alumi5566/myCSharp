using System;
using System.Collections.Generic;
namespace Samples;

// public so other namesapce can access this when calling
public enum VehicleType {
    Bus, Sedan, Bike
}

// public so we can create Vehicle anywhere in project
// abstract for inheritance
public abstract class Vehicle {
    // Public getter, private setter: Type is fixed after construction.
    public string liscencePlate {get; private set;}
    // Public getter, private setter: Type is fixed after construction.
    public VehicleType type {get; private set;}
    // protect so only sub-class can call this constructor
    protected Vehicle(VehicleType type, string liscencePlate) {
        this.liscencePlate = liscencePlate;
        this.type = type;
    }
}

// public so we can create Vehicle anywhere in project
public class Bus : Vehicle {
    public Bus(string liscencePlate) : base(VehicleType.Bus, liscencePlate) { }
}
public class Sedan : Vehicle {
    public Sedan(string liscencePlate) : base(VehicleType.Sedan, liscencePlate) { }
}
public class Bike : Vehicle {
    public Bike(string liscencePlate) : base(VehicleType.Bike, liscencePlate) { }
}

// Each individual space can hold a vehicle, release a vehicle
public class ParkingSpace {
    public int index {get;}
    public VehicleType spaceType {get;}
    // currentVehicle and isOccupied are public read, but only ParkingSpace itself can change it.
    public Vehicle currentVehicle {get; private set;}
    public bool isOccupied {get; private set;}
    public ParkingSpace(VehicleType type, int index) {
        this.index = index;
        this.spaceType = type;
        this.isOccupied = false;
    }
    public bool Park(Vehicle vehicle) {
        if (vehicle.type != spaceType) {
            return false;
        }
        this.currentVehicle = vehicle;
        this.isOccupied = true;
        return true;
    }
    public bool Release() {
        this.currentVehicle = null;
        this.isOccupied = false;
        return true;
    }
}

public class ParkingLot {
    private Dictionary<VehicleType, Queue<ParkingSpace>> availableSpace = new Dictionary<VehicleType, Queue<ParkingSpace>>();
    private Dictionary<Vehicle, ParkingSpace> vehicleLocation = new Dictionary<Vehicle, ParkingSpace>();
    public ParkingLot(int busCapacity, int sedanCapacity, int bikeCapacity) {
        availableSpace.Add(VehicleType.Bus, new Queue<ParkingSpace>());
        availableSpace.Add(VehicleType.Sedan, new Queue<ParkingSpace>());
        availableSpace.Add(VehicleType.Bike, new Queue<ParkingSpace>());
        for (int i=0;i<busCapacity;i++) {
            availableSpace[VehicleType.Bus].Enqueue(new ParkingSpace(VehicleType.Bus, i));
        }
        for (int i=0;i<sedanCapacity;i++) {
            availableSpace[VehicleType.Sedan].Enqueue(new ParkingSpace(VehicleType.Sedan, i));
        }
        for (int i=0;i<bikeCapacity;i++) {
            availableSpace[VehicleType.Bike].Enqueue(new ParkingSpace(VehicleType.Bike, i));
        }
    }
    public bool Park(Vehicle vehicle) {
        if (availableSpace[vehicle.type].Count <= 0) {
            Console.Write("ParkingLot for " + vehicle.type + " is full.");
            return false;
        }
        ParkingSpace sp = availableSpace[vehicle.type].Dequeue();
        sp.Park(vehicle);
        vehicleLocation[vehicle] = sp;
        return true;
    }
    public bool Release(Vehicle vehicle) {
        if (!vehicleLocation.ContainsKey(vehicle)) {
            Console.Write("Vehicle is not found.");
            return false;
        }
        ParkingSpace sp = vehicleLocation[vehicle];
        sp.Release();
        availableSpace[vehicle.type].Enqueue(sp);
        vehicleLocation.Remove(vehicle);
        return true;
    }
    public int CheckRemaining() {
        return availableSpace[VehicleType.Bus].Count + availableSpace[VehicleType.Sedan].Count + availableSpace[VehicleType.Bike].Count;
    }
}

public class ParkingLotsSample {
    public static void Run(){
        Console.WriteLine("ParkingLotsSample");
        ParkingLot lot = new ParkingLot(1, 2, 2);
        var car1 = new Sedan("CAR-123");
        var car2 = new Sedan("CAR-456");
        var bike1 = new Bike("BIKE-111");
        var truck1 = new Bus("TRUCK-999");

        lot.Park(car1);
        lot.Park(car2);
        lot.Park(bike1);
        lot.Park(truck1);

        lot.Park(new Sedan("CAR-789")); // no spot

        lot.Release(car1);
        lot.Park(new Sedan("CAR-789")); // now it can park
    }
}