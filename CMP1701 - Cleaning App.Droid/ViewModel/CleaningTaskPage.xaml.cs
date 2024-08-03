using CMP1701___Cleaning_App.ViewModels;
using CMP1701___Cleaning_App.Models;
using CMP1701___Cleaning_App.Droid.Models;

namespace CMP1701___Cleaning_App.Views
{
    public partial class CleaningTaskPage : ContentPage
    {
        public CleaningTaskPage(CleaningTask cleaningTask)
        {
            InitializeComponent();
            BindingContext = new CleaningTaskViewModel(cleaningTask);
        }
    }
}
