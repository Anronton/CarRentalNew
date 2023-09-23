namespace CarRental.Common.Interfaces;

public interface IData
{
    public List<IPerson> GetPersons();
    public List<IVehicle> GetVehicles();
    //public List<IBooking> GetBookings();

    // Dessa är IEnumerable<Interfaces> i Jonas projekt, förmodligen för att det ska ske något slags urval. så formulering lyder följande:
    /*
      IEnumerable<IPerson> GetPersons();

      IEnumerable<IVehicle> GetVehicles(VehicleStatuses status = default);

      IEnumerable<IBooking> GetBookings();
     
     */


}
