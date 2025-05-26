
using Microsoft.Maui.Controls;

namespace LayoustHerrera;

public partial class AbsoluteLayoutPage : ContentPage
{
    public AbsoluteLayoutPage()
    {
        InitializeComponent();
    }

    private void OnGoToGridLayoutClicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}
