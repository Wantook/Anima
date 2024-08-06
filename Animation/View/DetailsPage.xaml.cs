namespace Animation
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage()
        {
            InitializeComponent();
        }

        private async void OnFadeInClicked(object sender, EventArgs e)
        {
            
            await FadingLabel.FadeTo(1, 1000, Easing.Linear);
        }
    }
}
