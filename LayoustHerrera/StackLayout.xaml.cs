using Microsoft.Maui.Controls;

namespace LayoustHerrera
{
    public partial class StackLayout : ContentPage
    {
        public StackLayout()
        {
            InitializeComponent();
        }

        private void OnGoToFlexLayoutClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlexLayoutPage());
        }
    }
}
