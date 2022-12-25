using ADOPMAUI_Lessons.Views.Lesson05;
using Microsoft.Maui.Controls;

namespace ADOPMAUI_Lessons.ViewModels
{
    public class Lesson05aViewModel
    {
        public Lesson05aViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static Lesson05aViewModel()
        {
            All = new List<Lesson05aViewModel>
            {
                new Lesson05aViewModel(typeof(ContentPage1), "ContentPage1",
                        "Navigate to ContentPage1"),

                new Lesson05aViewModel(typeof(ContentPage2), "ContentPage2",
                        "Navigate to ContentPage2"),
                
                new Lesson05aViewModel(typeof(ContentPage3), "ContentPage3",
                        "Navigate to ContentPage3"),
            };
        }

        public static IList<Lesson05aViewModel> All { private set; get; }
    }
}
