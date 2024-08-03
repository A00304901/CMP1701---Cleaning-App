using CMP1701___Cleaning_App.Droid.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMP1701___Cleaning_App.Services
{
    public class RoomService
    {
        private readonly List<Room> _rooms;

        public RoomService()
        {
            _rooms = new List<Room>
            {
                new Room { RoomId = 1, RoomName = "Living Room", RoomSize = 25.0, FloorType = "Wood", IsOccupied = false, CleaningStatus = "Clean" },
                new Room { RoomId = 2, RoomName = "Bedroom", RoomSize = 15.0, FloorType = "Carpet", IsOccupied = true, CleaningStatus = "Dirty" }
            };
        }

        public Task<List<Room>> GetRoomsAsync()
        {
            return Task.FromResult(_rooms);
        }

        public Task<Room> GetRoomByIdAsync(int id)
        {
            var room = _rooms.FirstOrDefault(r => r.RoomId == id);
            return Task.FromResult(room);
        }

        public Task SaveRoomAsync(Room room)
        {
            var existingRoom = _rooms.FirstOrDefault(r => r.RoomId == room.RoomId);
            if (existingRoom != null)
            {
                _rooms.Remove(existingRoom);
            }
            _rooms.Add(room);
            return Task.CompletedTask;
        }
    }
}
