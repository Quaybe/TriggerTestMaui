
using System.Collections.ObjectModel;
using TriggerTestMaui.Services;

namespace TriggerTestMaui.ViewModel
{
    public partial class MainPageViewModel : BaseViewModel
    {   
        bool simpleTest = true;
        
        public MainPageViewModel(TestService testService)
        {
            this.testService = testService;
        }

        TestService testService;
        public ObservableCollection<TestModel> TestNumbers { get; } = new();

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
        async Task IncrementPulled()
        {
            if (simpleTest)
            {
                Int1++;
            }
            else // Not used for test
            {
                int localPulled;
                try
                {
                    foreach (var item in TestNumbers)
                    {
                        localPulled = Convert.ToInt32(item.Pulled);
                        localPulled++;
                        item.Pulled = localPulled.ToString();
                    }
                }
                catch (Exception ex)
                {
                    await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
                }
            }
        }
        [RelayCommand]
        async Task Reset()
        {
            Int1 = 0;
        }
    }
}
