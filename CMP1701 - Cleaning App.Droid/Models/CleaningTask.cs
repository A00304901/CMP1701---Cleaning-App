using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1701___Cleaning_App.Droid.Models
{
    /// <summary>
    /// The CleaningTask class represents a task in the cleaning application.
    /// Each task has a unique identifier, name, description, and is associated
    /// with a specific room. Additionally, it tracks the scheduled time for the 
    /// task and whether it has been completed. This class serves as a model for 
    /// organizing and managing cleaning tasks within the application.
    /// </summary>
    public class CleaningTask
{
    public int TaskId { get; set; }
    public string? TaskName { get; set; }
    public string? TaskDescription { get; set; }
    public string? RoomName { get; set; }
    public DateTime ScheduledTime { get; set; }
    public bool IsCompleted { get; set; }
}
}
