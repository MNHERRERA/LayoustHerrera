namespace LayoustHerrera
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // En lugar de AppShell, usar NavigationPage con MainPage
            return new Window(new NavigationPage(new MainPage()));
        }
    }
}
