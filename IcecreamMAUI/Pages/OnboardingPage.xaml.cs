namespace IcecreamMAUI.Pages;

public partial class OnboardingPage : ContentPage
{
	public OnboardingPage()
	{
		InitializeComponent();
	}

    private async void Signin_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SignInPage));
    }

    private async void Signup_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SignUpPage));
    }
}