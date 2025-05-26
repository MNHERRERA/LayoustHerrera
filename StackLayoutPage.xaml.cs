using Microsoft.Maui.Controls;

namespace LayoustHerrera
{
    public partial class StackLayoutPage : ContentPage
    {
        public StackLayoutPage()
        {
            InitializeComponent();
        }

        private void OnGoToFlexLayoutClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlexLayoutPage());
        }
    }
}
