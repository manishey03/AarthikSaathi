namespace AarthikSaathi_22069007
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage()) { Title = "AarthikSaathi_22069007" };
        }
    }
}
