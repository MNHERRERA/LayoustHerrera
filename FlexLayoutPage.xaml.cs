using Microsoft.Maui.Controls;

namespace LayoustHerrera
{
    public partial class FlexLayoutPage : ContentPage
    {
        public FlexLayoutPage()
        {
            InitializeComponent();
        }

        private void OnGoToAbsoluteLayoutClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayoutPage());
        }
    }
}
