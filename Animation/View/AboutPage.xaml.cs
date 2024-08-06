namespace Animation
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void OnSlideInClicked(object sender, EventArgs e)
        {
            
            await SlideInLabel.TranslateTo(0, 0, 500, Easing.CubicInOut);
        }
    }
}
