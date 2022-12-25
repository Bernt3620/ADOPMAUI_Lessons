using ADOPMAUI_Lessons.Views.Lesson06;
using Microsoft.Maui.Controls;

namespace ADOPMAUI_Lessons.ViewModels
{
    public class Lesson06bViewModel
    {
        public Lesson06bViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static Lesson06bViewModel()
        {
            All = new List<Lesson06bViewModel>
            {
                new Lesson06bViewModel(typeof(NonTrivialDataBinding1), "Non trivial Databinding 1",
                        "Without INotifyPropertyChange implemented"),

                new Lesson06bViewModel(typeof(NonTrivialDataBinding2), "Non trivial Databinding 2",
                        "With INotifyPropertyChange implemented"),

                new Lesson06bViewModel(typeof(NonTrivialDataBinding3), "Non trivial Databinding 3",
                        "Towards ViewModel"),

                new Lesson06bViewModel(typeof(NonTrivialDataBinding4), "Non trivial Databinding 4",
                        "Full ViewModel implemented"),

                new Lesson06bViewModel(typeof(NonTrivialDataBinding5), "Non trivial Databinding 5",
                        "L4 ListViewDemo implemented with full ViewModel"),
            };
        }

        public static IList<Lesson06bViewModel> All { private set; get; }
    }
}
