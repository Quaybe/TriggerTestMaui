
using System.Collections.ObjectModel;
using TriggerTestMaui.Services;

namespace TriggerTestMaui.ViewModel
{
    public partial class MainPageViewModel : BaseViewModel
    {
        TestService testService;
        public ObservableCollection<TestModel> TestNumbers { get; } = new();

        [ObservableProperty]
        bool isRefreshing;

        [RelayCommand]
        async Task GetNumbers()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;

                var testNumbers = await testService.GetTestNumbers();

                if (TestNumbers.Count != 0)
                    TestNumbers.Clear();

                foreach (var item in testNumbers)
                {
                    TestNumbers.Add(item);
                }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Error", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
                IsRefreshing = false;
            }
        }
        [RelayCommand]
        async Task IncrementPulled()
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

        public MainPageViewModel(TestService testService)
        { 
            this.testService = testService;
        }
    }
}
