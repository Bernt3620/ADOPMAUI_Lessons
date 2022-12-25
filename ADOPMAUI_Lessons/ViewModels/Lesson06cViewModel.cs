using ADOPMAUI_Lessons.Views.Lesson06;
using Microsoft.Maui.Controls;

namespace ADOPMAUI_Lessons.ViewModels
{
    public class Lesson06cViewModel
    {
        public Lesson06cViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static Lesson06cViewModel()
        {
            All = new List<Lesson06cViewModel>
            {
                new Lesson06cViewModel(typeof(UsingCommand1), "Viewmodel using Command 1",
                        "Full ViewModel implemented"),

                new Lesson06cViewModel(typeof(UsingCommand2), "Viewmodel using Command 2",
                        "L4 ListViewDemo implemented with full ViewModel"),

                new Lesson06cViewModel(typeof(DecimalKeypadPage), "Advanced Command",
                        "Decimal keypad with ViewModel and Commands"),
            };
        }

        public static IList<Lesson06cViewModel> All { private set; get; }
    }
}
