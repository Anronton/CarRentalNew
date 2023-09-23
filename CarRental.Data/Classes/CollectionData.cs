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
        _persons.Add(new Customer(1, "Jan", "Deg"));

        _vehicles.Add(new Car("SIX666", "Volvo", 1000, 2.5, Common.Enums.VehicleTypes.Combi, Common.Enums.VehicleStatuses.Available));

        _vehicles.Add(new Motorcycle("ABC123", "Yamaha", 3000, 1, Common.Enums.VehicleTypes.Motorcycle, Common.Enums.VehicleStatuses.Booked));
    }
    
    public List<IPerson> GetPersons() => _persons;
    public List<IVehicle> GetVehicles() => _vehicles;
    
}
