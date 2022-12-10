using ADOPMAUI_Lessons.Views.Lesson02;
using Microsoft.Maui.Controls;

namespace ADOPMAUI_Lessons.ViewModels
{
    public class Lesson02ViewModel
    {
        public Lesson02ViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static Lesson02ViewModel()
        {
            All = new List<Lesson02ViewModel>
            {
                
                // Part 1. Getting Started with XAML
                new Lesson02ViewModel(typeof(HelloXamlPage), "Hello, XAML",
                                      "Display a Label with many properties set"),

                new Lesson02ViewModel(typeof(XamlPlusCodePage), "XAML + Code",
                                      "Interact with a Slider and Button"),

                // Part 2. Essential XAML Syntax
                new Lesson02ViewModel(typeof(GridDemoPage), "Grid Demo",
                                      "Explore XAML syntax with the Grid"),

                 // Part 3. XAML Markup Extensions
                new Lesson02ViewModel(typeof(SharedResourcesPage), "Shared Resources",
                                      "Using resource dictionaries to share resources"),


                new Lesson02ViewModel(typeof(StaticDemoPage), "x:Static Demo",
                                      "Using the x:Static markup extensions"),

                new Lesson02ViewModel(typeof(TypeDemoPage), "x:Type Demo",
                                      "Associate Buttons with a Type"),

                new Lesson02ViewModel(typeof(ReferenceDemoPage), "x:Reference Demo",
                                      "Reference named elements on the page in Binding"),

                new Lesson02ViewModel(typeof(OnPlatformDemoPage), "OnPlatform Demo",
                        "Specify values per platform"),
 
                new Lesson02ViewModel(typeof(OnIdiomDemoPage), "OnIdiom Demo",
                        "Specify values per idiom"),

              
                new Lesson02ViewModel(typeof(SliderBindingsPage), "Slider Bindings",
                                      "Bind properties of two views on the page"),

                new Lesson02ViewModel(typeof(SliderTransformsPage), "Slider Transforms",
                                      "Use Sliders with bindings"),

                 new Lesson02ViewModel(typeof(StringFormattingPage), "String Formatting",
                                      "Use standard .NET formatting specfications"),
                 
                 new Lesson02ViewModel(typeof(MultiBindingStringFormatPage), "String Formatting",
                                      "Combine strings from a MultiBinding"),
             /*
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

        public static IList<Lesson02ViewModel> All { private set; get; }
    }
}
