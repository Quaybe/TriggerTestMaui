namespace TriggerTestMaui.View;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}