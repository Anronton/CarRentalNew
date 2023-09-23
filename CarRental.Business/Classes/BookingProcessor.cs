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
}
