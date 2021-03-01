using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]
namespace TodoASMX
{
	public class App : Application
	{
		public static TodoItemManager TodoManager { get; set; }

		public App ()
		{
			ThemeManager.ChangeTheme("Default"); //Initialize the Default Theme
			MainPage = new NavigationPage(new TodoListPage())
			{
				BarBackgroundColor = Color.FromHex("#941a1d")
			}; 

		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
