using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CMP1701___Cleaning_App.Droid.Models;

namespace CMP1701___Cleaning_App.Droid.ViewModel
{
    internal class CleaningDeviceViewModel : INotifyPropertyChanged
{
    private CleaningDevice _selectedDevice;

    public ObservableCollection<CleaningDevice> Devices { get; set; }

    public CleaningDevice SelectedDevice
    {
        get => _selectedDevice;
        set
        {
            _selectedDevice = value;
            OnPropertyChanged();
        }
    }

    public ICommand LoadDevicesCommand { get; set; }
    public ICommand SaveDeviceCommand { get; set; }

    public CleaningDeviceViewModel()
    {
        Devices = new ObservableCollection<CleaningDevice>();
        LoadDevicesCommand = new Command(LoadDevices);
        SaveDeviceCommand = new Command(SaveDevice);
    }

    private void LoadDevices()
    {
        // Here you would normally call a service to get data
        // For example:
        // Devices = await _deviceService.GetDevicesAsync();
    }

    private void SaveDevice()
    {
        // Here you would normally call a service to save the device
        // For example:
        // await _deviceService.SaveDeviceAsync(SelectedDevice);
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
}
