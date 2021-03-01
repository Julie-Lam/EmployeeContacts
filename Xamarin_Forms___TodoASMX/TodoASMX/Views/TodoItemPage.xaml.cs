using System;
using Xamarin.Forms;

namespace TodoASMX
{
	public partial class TodoItemPage : ContentPage
	{
		bool isNewItem;

		public TodoItemPage (bool isNew = false)
		{
			InitializeComponent ();
			isNewItem = isNew;
			themePicker.SelectedIndexChanged += ThemePicker_SelectedIndexChanged;

			//var todoItem = (TodoItem)BindingContext;
			//int department;
			//department = int.Parse(todoItem.Department);
			//if (department == 0)
			//{
			//	departmentEntry.Text = "General";
			//}
			//if (department == 1)
			//{
			//	departmentEntry.Text = "Information Technology";
			//}
			//if (department == 2)
			//{
			//	departmentEntry.Text = "Accounting";
			//}
			//if (department == 3)
			//{
			//	departmentEntry.Text = "Marketing";
			//}
			//else if (department == 4)
			//{
			//	departmentEntry.Text = "Human Resources";
			//}
		}


		private void ThemePicker_SelectedIndexChanged(object sender, EventArgs e)
		{
			ThemeManager.ChangeTheme(themePicker.SelectedItem.ToString());
		}

		async void OnSaveActivated (object sender, EventArgs e)
		{
			var todoItem = (TodoItem)BindingContext;

            await App.TodoManager.SaveTodoItemAsync (todoItem, isNewItem);
			await Navigation.PopAsync();
			await DisplayAlert("Success", "Contact Saved", "OK");
		}

		async void OnDeleteActivated (object sender, EventArgs e)
		{
			var todoItem = (TodoItem)BindingContext;
			await App.TodoManager.DeleteTodoItemAsync (todoItem);
			await Navigation.PopAsync ();
			await DisplayAlert("Success", "Contact Deleted", "OK");
		}

		async void OnCancelActivated (object sender, EventArgs e)
		{
			await Navigation.PopAsync ();
		}
	}
}
