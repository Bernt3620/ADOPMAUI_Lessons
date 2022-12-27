using ADOPMAUI_Lessons.Views.Lesson03;
using Microsoft.Maui.Controls;

namespace ADOPMAUI_Lessons.ViewModels
{
    public class Lesson03aViewModel
    {
        public Lesson03aViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static Lesson03aViewModel()
        {
            All = new List<Lesson03aViewModel>
            {
                
                // Part 1. Getting Started with XAML
                new Lesson03aViewModel(typeof(AbsoluteLayoutDemo), "AbsoluteLayoutDemo",
                                      "Demonstrate the AbsoluteLayout"),

                new Lesson03aViewModel(typeof(GridLayoutDemo), "GridLayoutDemo",
                                      "Demonstrate the GridLayout")
            };
        }

        public static IList<Lesson03aViewModel> All { private set; get; }
    }
}
