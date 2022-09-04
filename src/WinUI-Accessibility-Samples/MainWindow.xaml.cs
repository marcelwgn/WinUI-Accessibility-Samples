namespace WinUIAccessibilitySamples
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.Title = "WinUI Accessibility Samples Preview";
        }

        private void RootNavigation_SelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            var name = args.SelectedItemContainer.Tag as string;

            NavigationFrame.Navigate(Type.GetType("WinUIAccessibilitySamples.Samples." + name));
        }
    }
}
