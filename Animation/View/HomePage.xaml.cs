namespace Animation
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void OnAnimateRotationClicked(object sender, EventArgs e)
        {
            
            await RotatingLabel.RotateTo(360, 2000, Easing.Linear);
            
            RotatingLabel.Rotation = 0;
        }
    }
}
