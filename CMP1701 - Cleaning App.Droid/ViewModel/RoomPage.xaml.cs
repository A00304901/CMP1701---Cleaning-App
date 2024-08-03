using System;
using Microsoft.Maui.Controls;
using CMP1701___Cleaning_App.Droid.Models;

namespace CMP1701___Cleaning_App
{
    public partial class RoomPage : ContentPage
    {
        public Room CurrentRoom { get; set; }

        public RoomPage(Room room)
        {
            InitializeComponent();
            CurrentRoom = room;
            BindRoomDetails();
        }

        private void BindRoomDetails()
        {
            if (CurrentRoom != null)
            {
                RoomIdEntry.Text = CurrentRoom.RoomId.ToString();
                RoomNameEntry.Text = CurrentRoom.RoomName;
                RoomSizeEntry.Text = CurrentRoom.RoomSize.ToString();
                FloorTypeEntry.Text = CurrentRoom.FloorType;
                IsOccupiedSwitch.IsToggled = CurrentRoom.IsOccupied;
                CleaningStatusEntry.Text = CurrentRoom.CleaningStatus;
            }
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Update the CurrentRoom object with the values from the UI
            CurrentRoom.RoomName = RoomNameEntry.Text;
            CurrentRoom.RoomSize = double.TryParse(RoomSizeEntry.Text, out double size) ? size : 0;
            CurrentRoom.FloorType = FloorTypeEntry.Text;
            CurrentRoom.IsOccupied = IsOccupiedSwitch.IsToggled;
            CurrentRoom.CleaningStatus = CleaningStatusEntry.Text;

            // TODO: Save the updated room details to a database or other storage

            DisplayAlert("Success", "Room details saved successfully.", "OK");
        }
    }
}
