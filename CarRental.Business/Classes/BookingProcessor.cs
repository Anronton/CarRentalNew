using CarRental.Common.Interfaces;

namespace CarRental.Business.Classes;

public class BookingProcessor
{
    IData _data;

    public BookingProcessor(IData data)
    {
        _data = data;
    }

    public List<IPerson> GetPersons() => _data.GetPersons();
    public List<IVehicle> GetVehicles() => _data.GetVehicles();
    //public List<IBooking> GetBookings() => _data.GetBooking
    //Dessa behöver nog också bli public IEnumerables<Interface> sen metoden

    //också lär det tillkomma logik för att beräkna mer kostnader här, kanske inte direkt i klassen som jag gjort nu.

}
