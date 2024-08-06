namespace Animation
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private async void OnAnimateScaleRotateClicked(object sender, EventArgs e)
        {
            
            await ScaleRotateLabel.ScaleTo(1.5, 500, Easing.CubicInOut);
            await ScaleRotateLabel.RotateTo(360, 500, Easing.CubicInOut);
            await ScaleRotateLabel.ScaleTo(1, 500, Easing.CubicInOut);
            ScaleRotateLabel.Rotation = 0; 
        }
    }
}
