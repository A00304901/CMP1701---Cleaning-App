using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1701 - Cleaning App.WinUI.Models
{
    /// <summary>
    /// The Room class represents a room within a cleaning application.
    /// It contains fields to store the room's unique identifier (RoomId), 
    /// name (RoomName), size in square meters (RoomSize), type of flooring 
    /// (FloorType), occupancy status (IsOccupied), and the current cleaning 
    /// status (CleaningStatus). This class is used to manage and track 
    /// information about individual rooms for cleaning purposes.
    /// </summary>
    internal class Room
{
    public int RoomId { get; set; }
    public string RoomName { get; set; }
    public double RoomSize { get; set; }
    public string FloorType { get; set; }
    public bool IsOccupied { get; set; }
    public string CleaningStatus { get; set; }
}
}
