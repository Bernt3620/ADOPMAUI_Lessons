using Microsoft.Maui.Controls;
using System.Text.RegularExpressions;


using ADOPMAUI_Lessons.Views.Lesson07;
namespace ADOPMAUI_Lessons.ViewModels
{
    public class Lesson07aViewModel
    {
        private static string RoutePrefix = "//lesson7/";
        public Type Type { private set; get; }
        public string Title { private set; get; }
        public string Description { private set; get; }
        public string Route { private set; get; }

        public Lesson07aViewModel(Type type, string title, string description, string route = null)
        {
            Type = type;
            Title = title;
            Description = description;
            Route = route ?? RoutePrefix + Regex.Replace(title.ToLower(), @"\W", "");
        }
        static Lesson07aViewModel()
        {
            All = new List<Lesson07aViewModel>
            {
                new Lesson07aViewModel(typeof(PrimesAppStep1), "Primes Application Step1",
                        "Very basic. Moving Model and Services into MAUI"),
            };

            foreach (var item in All)
            {
                Routing.RegisterRoute(item.Route, item.Type);
            }
        }

        public static IList<Lesson07aViewModel> All { private set; get; }
    }
}
