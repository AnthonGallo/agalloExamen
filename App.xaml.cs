using agalloExamen.Views;

namespace agalloExamen
{
    public partial class App : Application
    {
        public static string UsuarioConectado { get; set; } = string.Empty;

        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new login()));
        }
    }
}