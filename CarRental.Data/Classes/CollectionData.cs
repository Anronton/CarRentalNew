using CarRental.Common.Classes;
using CarRental.Common.Interfaces;

namespace CarRental.Data.Classes;

public class CollectionData : IData
{
    readonly List<IPerson> _persons = new List<IPerson>();
    readonly List<IVehicle> _vehicles = new List<IVehicle>();
    //readonly List<IBooking> _bookings = new List<IBooking>();

    public CollectionData() => SeedData();

    void SeedData()
    {
        //Vehicles
        _vehicles.Add(new Car("SIX666", "Volvo", 1000, 2.5, Common.Enums.VehicleTypes.Combi, Common.Enums.VehicleStatuses.Available));
        _vehicles.Add(new Motorcycle("ABC123", "Yamaha", 3000, 1, Common.Enums.VehicleTypes.Motorcycle, Common.Enums.VehicleStatuses.Booked));
        _vehicles.Add(new Car("BKJ142", "Ford", 2500, 2, Common.Enums.VehicleTypes.Van, Common.Enums.VehicleStatuses.Available));
        _vehicles.Add(new Car("BLZ420", "BMW", 5000, 5, Common.Enums.VehicleTypes.Sedan, Common.Enums.VehicleStatuses.Available));
        _vehicles.Add(new Car("ORT141", "Saab", 10000, 1.5, Common.Enums.VehicleTypes.Combi, Common.Enums.VehicleStatuses.Available));

        //Bookings
        //_bookings.Add(new Booking()); 

        //Customers
        _persons.Add(new Customer(960321, "Jan", "Deg"));
        _persons.Add(new Customer(690101, "John", "Doe"));
        _persons.Add(new Customer(721111, "Jane", "Smith"));
    }
    
    public List<IPerson> GetPersons() => _persons;
    public List<IVehicle> GetVehicles() => _vehicles;

    //public List<IBooking> Get Bookings() => _bookings;

    // Dessa tre ovan ska då också vara IEnumerable<Interface> för att det ska ske något slags urval
    
}
