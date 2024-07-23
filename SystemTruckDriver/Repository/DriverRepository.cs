using Microsoft.EntityFrameworkCore;
using SystemTruckDriver.Data;
using SystemTruckDriver.Models;
using SystemTruckDriver.Repository.Interfaces;

namespace SystemTruckDriver.Repository
{
    public class DriverRepository : IDriverRepository
    {
        private readonly SystemTruckDbContext _dbContext;
        public DriverRepository(SystemTruckDbContext systemTruckDbContext)
        {
            _dbContext = systemTruckDbContext;
        }

        public async Task<List<DriverModel>> GetAllDrivers()
        {
            return await _dbContext.Drivers.ToListAsync();
        }

        public async Task<DriverModel> GetDriverById(int id)
        {
            return await _dbContext.Drivers.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<DriverModel> AddDriver(DriverModel driver)
        {
            await _dbContext.Drivers.AddAsync(driver);
            await _dbContext.SaveChangesAsync();
            return driver;
        }
        public async Task<DriverModel> UpdateDriver(DriverModel driver, int id)
        {
           DriverModel driverById = await GetDriverById(id);
            if(driver == null)
            {
                throw new Exception("User not found");
            }
            driverById.CodeCNH = driver.CodeCNH;
            driverById.Name = driver.Name;  
            _dbContext.Drivers.Update(driverById);
            await _dbContext.SaveChangesAsync();
            return driverById;
        }

        public async Task<bool> DeleteDriver(int id)
        {
            DriverModel driverById = await GetDriverById(id);
            if (driverById == null)
            {
                throw new Exception("User not found");
            }

            _dbContext.Remove(driverById);
            await _dbContext.SaveChangesAsync();

            return true;
        } 

      
    }
}
