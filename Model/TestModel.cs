namespace TriggerTestMaui.Model
{
    public class TestModel : ObservableObject
    {
        public string ID { get; set; }
        public string pulled;
        public string Pulled
        {
            get => pulled;
            set => SetProperty(ref pulled, value);
        }
        public string Sold { get; set; }
    }
}
