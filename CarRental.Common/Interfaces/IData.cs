namespace CarRental.Common.Interfaces;

public interface IData
{
    public List<IPerson> GetPersons();
    public List<IVehicle> GetVehicles();
    //List<IBooking> GetBookings();
}
