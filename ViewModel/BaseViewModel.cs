
namespace TriggerTestMaui.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    
    public BaseViewModel()
    {
    
    }
    
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool isBusy;

    [ObservableProperty]
    string title;

    [ObservableProperty]
    string userName;
    
    [ObservableProperty]
    DateTime baseDateTime = DateTime.Now;

    public bool IsNotBusy => !IsBusy;
}


