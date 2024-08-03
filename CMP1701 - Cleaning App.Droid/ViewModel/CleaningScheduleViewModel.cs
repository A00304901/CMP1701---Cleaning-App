using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CMP1701___Cleaning_App.Droid.Models;

namespace CMP1701___Cleaning_App.ViewModels
{
    public class CleaningScheduleViewModel : INotifyPropertyChanged
    {
        private CleaningSchedule _selectedSchedule;

        public ObservableCollection<CleaningSchedule> Schedules { get; set; }

        public CleaningSchedule SelectedSchedule
        {
            get => _selectedSchedule;
            set
            {
                _selectedSchedule = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoadSchedulesCommand { get; set; }
        public ICommand SaveScheduleCommand { get; set; }

        public CleaningScheduleViewModel()
        {
            Schedules = new ObservableCollection<CleaningSchedule>();
            LoadSchedulesCommand = new Command(LoadSchedules);
            SaveScheduleCommand = new Command(SaveSchedule);
        }

        private void LoadSchedules()
        {
            // Here you would normally call a service to get data
            // For example:
            // var schedules = await _scheduleService.GetSchedulesAsync();
            // foreach (var schedule in schedules)
            // {
            //     Schedules.Add(schedule);
            // }
        }

        private void SaveSchedule()
        {
            // Here you would normally call a service to save the schedule
            // For example:
            // await _scheduleService.SaveScheduleAsync(SelectedSchedule);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
