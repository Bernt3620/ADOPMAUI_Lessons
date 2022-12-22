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
             
                /*
                // Part 1. Getting Started with XAML
                new Lesson04ViewModel(typeof(HelloXamlPage), "Hello, XAML",
                                      "Display a Label with many properties set"),

                new Lesson04ViewModel(typeof(XamlPlusCodePage), "XAML + Code",
                                      "Interact with a Slider and Button"),

                // Part 2. Essential XAML Syntax
                new Lesson04ViewModel(typeof(GridDemoPage), "Grid Demo",
                                      "Explore XAML syntax with the Grid"),

                 // Part 3. XAML Markup Extensions
                new Lesson04ViewModel(typeof(SharedResourcesPage), "Shared Resources",
                                      "Using resource dictionaries to share resources"),


                new Lesson04ViewModel(typeof(StaticDemoPage), "x:Static Demo",
                                      "Using the x:Static markup extensions"),

                new Lesson04ViewModel(typeof(TypeDemoPage), "x:Type Demo",
                                      "Associate Buttons with a Type"),

                new Lesson04ViewModel(typeof(ReferenceDemoPage), "x:Reference Demo",
                                      "Reference named elements on the page in Binding"),

                new Lesson04ViewModel(typeof(OnPlatformDemoPage), "OnPlatform Demo",
                        "Specify values per platform"),
 
                new Lesson04ViewModel(typeof(OnIdiomDemoPage), "OnIdiom Demo",
                        "Specify values per idiom"),

              
                new Lesson04ViewModel(typeof(SliderBindingsPage), "Slider Bindings",
                                      "Bind properties of two views on the page"),

                new Lesson04ViewModel(typeof(SliderTransformsPage), "Slider Transforms",
                                      "Use Sliders with reverse bindings"),

                 new Lesson04ViewModel(typeof(StringFormattingPage), "String Formatting",
                                      "Use standard .NET formatting specfications"),
                 
                 new Lesson04ViewModel(typeof(MultiBindingStringFormatPage), "String Formatting",
                                      "Combine strings from a MultiBinding"),
           
                new PageDataViewModel(typeof(ListViewDemoPage), "String Formatting",
                                      "Use a ListView with data bindings"),

                // Part 5. From Data Bindings to MVVM
                new PageDataViewModel(typeof(OneShotDateTimePage), "One-Shot DateTime",
                                      "Obtain the current DateTime and display it"),

                new PageDataViewModel(typeof(ClockPage), "Clock",
                                      "Dynamically display the current time"),

                new PageDataViewModel(typeof(HslColorScrollPage), "HSL Color Scroll",
                                      "Use a view model to select HSL colors"),

                new PageDataViewModel(typeof(KeypadPage), "Keypad",
                                      "Use a view model for numeric keypad logic")
                */
            };
        }

        public static IList<Lesson06aViewModel> All { private set; get; }
    }
}
