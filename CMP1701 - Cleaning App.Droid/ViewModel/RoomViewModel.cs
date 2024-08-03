using CMP1701___Cleaning_App.Droid.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CMP1701___Cleaning_App.ViewModels
{
    public class RoomViewModel : INotifyPropertyChanged
    {
        private Room _room;

        public RoomViewModel(Room room)
        {
            _room = room;
        }

        public int RoomId
        {
            get => _room.RoomId;
            set
            {
                if (_room.RoomId != value)
                {
                    _room.RoomId = value;
                    OnPropertyChanged();
                }
            }
        }

        public string RoomName
        {
            get => _room.RoomName;
            set
            {
                if (_room.RoomName != value)
                {
                    _room.RoomName = value;
                    OnPropertyChanged();
                }
            }
        }

        public double RoomSize
        {
            get => _room.RoomSize;
            set
            {
                if (_room.RoomSize != value)
                {
                    _room.RoomSize = value;
                    OnPropertyChanged();
                }
            }
        }

        public string FloorType
        {
            get => _room.FloorType;
            set
            {
                if (_room.FloorType != value)
                {
                    _room.FloorType = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsOccupied
        {
            get => _room.IsOccupied;
            set
            {
                if (_room.IsOccupied != value)
                {
                    _room.IsOccupied = value;
                    OnPropertyChanged();
                }
            }
        }

        public string CleaningStatus
        {
            get => _room.CleaningStatus;
            set
            {
                if (_room.CleaningStatus != value)
                {
                    _room.CleaningStatus = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
