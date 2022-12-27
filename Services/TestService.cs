namespace TriggerTestMaui.Services
{
    public class TestService
    {
        List<TestModel> testNumbers = new();

        public async Task<List<TestModel>> GetTestNumbers()
        {
            string JSONPickTickets = "[{\"ID\":\"01\",\"Sold\":\"1\",\"Pulled\":\"0\"}," +
                                     "{\"ID\":\"02\",\"Sold\":\"3\",\"Pulled\":\"0\"}]";

            testNumbers = JsonConvert.DeserializeObject<List<TestModel>>(JSONPickTickets);
            return testNumbers;
        }
    }
}
