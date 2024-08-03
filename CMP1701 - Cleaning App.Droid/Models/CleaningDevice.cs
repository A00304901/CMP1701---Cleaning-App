using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1701___Cleaning_App.Droid.Models
{
    /// <summary>
    /// The CleaningDevice class represents a cleaning device within the cleaning application.
    /// It contains properties to store information about the device such as its unique identifier,
    /// name, type, battery level, status, and the room it is assigned to. This class is essential
    /// for managing and tracking the state and assignment of cleaning devices within the system.
    /// </summary>
        internal class CleaningDevice
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceType { get; set; }
        public double BatteryLevel { get; set; }
        public string DeviceStatus { get; set; }
        public string RoomAssigned { get; set; }
    }
}
