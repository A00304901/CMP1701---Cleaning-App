using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMP1701___Cleaning_App.Droid.Models;

namespace CMP1701___Cleaning_App.Droid.Services
{
    internal interface ICleaningDeviceService
    {
        Task<List<CleaningDevice>> GetDevicesAsync();
        Task SaveDeviceAsync(CleaningDevice device);
    }

    public class CleaningDeviceService : ICleaningDeviceService
    {
        public Task<List<CleaningDevice>> GetDevicesAsync()
        {
            // Simulate fetching data
            var devices = new List<CleaningDevice>
            {
                new CleaningDevice { DeviceId = 1, DeviceName = "Vacuum", DeviceType = "Robot", BatteryLevel = 80, DeviceStatus = "Charging", RoomAssigned = "Living Room" },
                new CleaningDevice { DeviceId = 2, DeviceName = "Mop", DeviceType = "Manual", BatteryLevel = 40, DeviceStatus = "Idle", RoomAssigned = "Kitchen" }
            };
            return Task.FromResult(devices);
        }

        public Task SaveDeviceAsync(CleaningDevice device)
        {
            // Simulate saving data
            return Task.CompletedTask;
        }
    }
}