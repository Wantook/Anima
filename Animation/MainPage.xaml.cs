namespace Animation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAnimateButtonClicked(object sender, EventArgs e)
        {
            
            await AnimatedLabel.ScaleTo(1.5, 500, Easing.CubicInOut);
            await AnimatedLabel.ScaleTo(1, 500, Easing.CubicInOut);
        }

        private async void OnGoToDetailsClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Details");
        }
    }
}
