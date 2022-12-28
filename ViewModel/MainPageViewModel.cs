
using System.Collections.ObjectModel;
using TriggerTestMaui.Services;

namespace TriggerTestMaui.ViewModel
{
    public partial class MainPageViewModel : BaseViewModel
    {   
        //public MainPageViewModel(TestService testService)  // Not needed for this example.
        //{
        //    this.testService = testService;
        //}

        //TestService testService;
        
        [ObservableProperty]
        bool isRefreshing;
        [ObservableProperty]
        int int1 = 0;
        [ObservableProperty]
        int int2 = 2;

        //[RelayCommand]
        //async Task GetNumbers()
        //{
        //    if (IsBusy)
        //        return;

        //    try
        //    {
        //        IsBusy = true;

        //        var testNumbers = await testService.GetTestNumbers();

        //        if (TestNumbers.Count != 0)
        //            TestNumbers.Clear();

        //        foreach (var item in testNumbers)
        //        {
        //            TestNumbers.Add(item);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
        //    }
        //    finally
        //    {
        //        IsBusy = false;
        //        IsRefreshing = false;
        //    }
        //}
        [RelayCommand]
        async Task IncrementInt()
        {   
            Int1++;
        }
        [RelayCommand]
        async Task DecrementInt()
        {
            Int1--;
        }
        [RelayCommand]
        async Task Reset()
        {
            Int1 = 0;
        }
    }
}
