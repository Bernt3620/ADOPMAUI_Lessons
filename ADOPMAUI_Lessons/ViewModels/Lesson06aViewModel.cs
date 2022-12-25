using ADOPMAUI_Lessons.Views.Lesson06;
using Microsoft.Maui.Controls;

namespace ADOPMAUI_Lessons.ViewModels
{
    public class Lesson06aViewModel
    {
        public Lesson06aViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static Lesson06aViewModel()
        {
            All = new List<Lesson06aViewModel>
            {
                new Lesson06aViewModel(typeof(ActivityProgressPage), "ActivityIndicator and ProgressBar Demos",
                        "Show usage of Activity and Progress indicators"),
            };
        }

        public static IList<Lesson06aViewModel> All { private set; get; }
    }
}
