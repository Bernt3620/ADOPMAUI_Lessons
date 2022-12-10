using ADOPMAUI_Lessons.Models;
using ADOPMAUI_Lessons.Views.Lesson04;
using ADOPMAUI_Lessons.Views.Lesson05;


namespace ADOPMAUI_Lessons;

public partial class AppShell : Shell
{
    public Dictionary<string, Type> Routes { get; private set; } = new Dictionary<string, Type>();

    public AppShell()
	{
		InitializeComponent();
        RegisterRoutes();
	}

    void RegisterRoutes()
    {
        //register the routes which are not specified in the AppShell.xaml
        Routes.Add("actions", typeof(ContentPage1));
        Routes.Add("alerts", typeof(ContentPage2));
        Routes.Add("prompts", typeof(ContentPage3));

        foreach (var item in Routes)
        {
            Routing.RegisterRoute(item.Key, item.Value);
        }
    }

    //alternative constructor to show parameter passing from App.xaml.cs
    public AppShell((DateTime date, string greeting) shellData) : this()
	{
		//Only to demonstrate using parameters to pass data at page construction time
		var dt = shellData.date;
		var s = shellData.greeting;

        var aTab = new Tab { Title = "Passing data using constructor" };
		aTab.Items.Add(new ShellContent
        {
            Title = "Passing data using constructor",
            Route = "passingdatacons",
            ContentTemplate = new DataTemplate(() => new PassingDataConstructorPage(dt, s))
        });
        flyLesson04.Items.Add(aTab);


        var Colors = NamedColor.All.ToList();
        aTab = new Tab { Title = Colors[0].FriendlyName };
        aTab.Items.Add(new ShellContent
        {
            Title = Colors[0].FriendlyName,
            Route = Colors[0].FriendlyName,
            ContentTemplate = new DataTemplate(() => new TabbedColorPage(Colors[0]))
        });
        flyLesson05.Items.Add(aTab);

        aTab = new Tab { Title = Colors[1].FriendlyName };
        aTab.Items.Add(new ShellContent
        {
            Title = Colors[1].FriendlyName,
            Route = Colors[1].FriendlyName,
            ContentTemplate = new DataTemplate(() => new TabbedColorPage(Colors[1]))
        });
        flyLesson05.Items.Add(aTab);

        aTab = new Tab { Title = Colors[2].FriendlyName };
        aTab.Items.Add(new ShellContent
        {
            Title = Colors[2].FriendlyName,
            Route = Colors[2].FriendlyName,
            ContentTemplate = new DataTemplate(() => new TabbedColorPage(Colors[2]))
        });
        flyLesson05.Items.Add(aTab);


    }

    protected override void OnNavigated(ShellNavigatedEventArgs args)
    {
        base.OnNavigated(args);
    }
}
