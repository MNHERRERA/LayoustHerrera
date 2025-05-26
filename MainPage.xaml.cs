using Microsoft.Maui.Controls;

namespace LayoustHerrera
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGoToStackLayoutClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayoutPage());
        }
    }
}
