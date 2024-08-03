using CMP1701___Cleaning_App.Droid.Models;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CMP1701___Cleaning_App.ViewModels
{
    public class CleaningTaskViewModel : INotifyPropertyChanged
    {
        private CleaningTask _cleaningTask;

        public CleaningTaskViewModel(CleaningTask cleaningTask)
        {
            _cleaningTask = cleaningTask;
        }

        public int TaskId
        {
            get => _cleaningTask.TaskId;
            set
            {
                if (_cleaningTask.TaskId != value)
                {
                    _cleaningTask.TaskId = value;
                    OnPropertyChanged();
                }
            }
        }

        public string TaskName
        {
            get => _cleaningTask.TaskName;
            set
            {
                if (_cleaningTask.TaskName != value)
                {
                    _cleaningTask.TaskName = value;
                    OnPropertyChanged();
                }
            }
        }

        public string TaskDescription
        {
            get => _cleaningTask.TaskDescription;
            set
            {
                if (_cleaningTask.TaskDescription != value)
                {
                    _cleaningTask.TaskDescription = value;
                    OnPropertyChanged();
                }
            }
        }

        public string RoomName
        {
            get => _cleaningTask.RoomName;
            set
            {
                if (_cleaningTask.RoomName != value)
                {
                    _cleaningTask.RoomName = value;
                    OnPropertyChanged();
                }
            }
        }

        public DateTime ScheduledTime
        {
            get => _cleaningTask.ScheduledTime;
            set
            {
                if (_cleaningTask.ScheduledTime != value)
                {
                    _cleaningTask.ScheduledTime = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsCompleted
        {
            get => _cleaningTask.IsCompleted;
            set
            {
                if (_cleaningTask.IsCompleted != value)
                {
                    _cleaningTask.IsCompleted = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
