using SystemTruckDriver.Models;

namespace SystemTruckDriver.Repository.Interfaces
{
    public interface IDriverRepository
    {
        Task<List<DriverModel>> GetAllDrivers();
        Task<DriverModel> GetDriverById(int id);
        Task<DriverModel> AddDriver(DriverModel driver);
        Task<DriverModel> UpdateDriver(DriverModel driver, int id);
        Task<bool> DeleteDriver(int id);
    }
}
