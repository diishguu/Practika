namespace Pra
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPage1());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
