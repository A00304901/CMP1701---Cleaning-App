using Microsoft.Maui.Controls;
using CMP1701___Cleaning_App.Droid.Models;

namespace CMP1701___Cleaning_App
{
    public partial class CleaningDevicePage : ContentPage
    {
        private CleaningDevice _cleaningDevice;

        public CleaningDevicePage(CleaningDevice cleaningDevice)
        {
            InitializeComponent();
            _cleaningDevice = cleaningDevice;
            PopulateDeviceDetails();
        }

        private void PopulateDeviceDetails()
        {
            if (_cleaningDevice == null)
                return;

            DeviceIdLabel.Text = _cleaningDevice.DeviceId.ToString();
            DeviceNameLabel.Text = _cleaningDevice.DeviceName;
            DeviceTypeLabel.Text = _cleaningDevice.DeviceType;
            BatteryLevelLabel.Text = $"{_cleaningDevice.BatteryLevel}%";
            DeviceStatusLabel.Text = _cleaningDevice.DeviceStatus;
            RoomAssignedLabel.Text = _cleaningDevice.RoomAssigned;
        }
    }
}
