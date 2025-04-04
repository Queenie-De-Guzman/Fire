using Firebase.Auth;
using Microsoft.Maui.Storage;
using System;

namespace Fire.Pages
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
			LoadUserData();
		}

		private void LoadUserData()
		{
			// Kunin ang email mula sa local storage (Preferences)
			string userEmail = Preferences.Get("UserEmail", "user@example.com");

			WelcomeLabel.Text = "Welcome!";
			UserEmailLabel.Text = userEmail;
		}

		private async void OnLogoutClicked(object sender, EventArgs e)
		{
			// Clear saved email (logout user)
			Preferences.Remove("UserEmail");

			// Redirect to Login Page
			await Navigation.PushModalAsync(new LoginPage());
		}
	}
}
