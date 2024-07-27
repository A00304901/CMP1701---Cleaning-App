using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1701 - Cleaning App.WinUI.Models
{
    /// <summary>
    /// Represents a schedule for cleaning tasks within a facility.
    /// </summary>
    internal class CleaningSchedule
{
    public int ScheduleId { get; set; }
    public int RoomId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Frequency { get; set; }
    public bool IsActive { get; set; }
}
}
