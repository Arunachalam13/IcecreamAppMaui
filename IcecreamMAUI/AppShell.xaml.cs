using IcecreamMAUI.Pages;

namespace IcecreamMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(SignInPage), typeof(SignInPage));
            //Routing.RegisterRoute(nameof(SignUpPage), typeof(SignUpPage));
            RegisterRoute();
        }

        private static readonly Type[] types = [
            typeof(SignUpPage),
            typeof(SignInPage),
            typeof(MyOrdersPage),
            typeof(OrderDetailsPage),
            typeof(DetailsPage),
        ];

        private static void RegisterRoute()
        {
            foreach (var pageType in types)
            {
                Routing.RegisterRoute(pageType.Name, pageType);
            }
        }

        private async void FlyoutFooter_Tapped(object sender, TappedEventArgs e)
        {
            await Launcher.OpenAsync("https://github.com/Arunachalam13");
        }
    }
}
