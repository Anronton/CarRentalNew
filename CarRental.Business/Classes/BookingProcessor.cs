using CarRental.Common.Interfaces;

namespace CarRental.Business.Classes;

public class BookingProcessor
{
    IData _data;

    public BookingProcessor(IData data)
    {
        _data = data;
    }

    public IEnumerable<IPerson> GetPersons() => _data.GetPersons();
    public IEnumerable<IVehicle> GetVehicles() => _data.GetVehicles();
    public IEnumerable<IBooking> GetBookings() => _data.GetBookings();
    
    //också lär det tillkomma logik för att beräkna mer kostnader här, kanske inte direkt i klassen som jag gjort nu.

}
