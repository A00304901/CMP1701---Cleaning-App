using Microsoft.Maui.Controls;
using CMP1701___Cleaning_App.Droid.Models;
using CMP1701___Cleaning_App.Droid.ViewModel;
using Android.DeviceLock;

namespace CMP1701___Cleaning_App
{
    public partial class CleaningDevicePage : ContentPage
    {
        private CleaningDevice CleaningDevice;

        public CleaningDevicePage(CleaningDevice _cleaningDevice)
        {
            InitializeComponent();
            CleaningDevice = _cleaningDevice;
            populateDeviceDetails();
        }

        private void populateDeviceDetails()
        {
            DeviceIdLabel.Text = CleaningDevice.DeviceId.ToString();
            DeviceNameLabel.Text = CleaningDevice.DeviceName;
            DeviceTypeLabel.Text = CleaningDevice.DeviceType;
            BatteryLevelLabel.Text = $"{CleaningDevice.BatteryLevel}%";
            DeviceStatusLabel.Text = CleaningDevice.DeviceStatus;
            RoomAssignedLabel.Text = CleaningDevice.RoomAssigned;
        }
    }
}
