using ADOPMAUI_Lessons.Views.Lesson04;
using Microsoft.Maui.Controls;

namespace ADOPMAUI_Lessons.ViewModels
{
    public class Lesson04aViewModel
    {
        public Lesson04aViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static Lesson04aViewModel()
        {
            All = new List<Lesson04aViewModel>
            {
                new Lesson04aViewModel(typeof(SettingValueDemoPage), "Setting and Getting Values Demo",
                        "Set and get values from various UI elements"),

                new Lesson04aViewModel(typeof(AlteringViewXamlPage), "Altering View",
                        "Alter view properties using XAML binding"),

                new Lesson04aViewModel(typeof(ListViewDemoPage), "ListView Demo",
                        "Use a ListView with data bindings"),
 
                new Lesson04aViewModel(typeof(ListViewCustomizationPage), "ListView Customization",
                        "Customize a ListView using ViewCell"),
                
                new Lesson04aViewModel(typeof(ListViewGroupingPage), "ListView Grouping",
                        "Group ListView using GroupHeaderTemplate and Linq"),
               
            };
        }

        public static IList<Lesson04aViewModel> All { private set; get; }
    }
}
