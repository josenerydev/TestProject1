using FluentAssertions;

using Flurl.Http;

using Newtonsoft.Json;

using System.Threading.Tasks;

using TestProject1.Models;

using Xunit;
using Xunit.Abstractions;
using Xunit.Priority;

namespace TestProject1
{
    [TestCaseOrderer(PriorityOrderer.Name, PriorityOrderer.Assembly)]
    public class UnitTest1
    {
        private readonly string baseUrl = "http://calapi.inadiutorium.cz/api/v0/en/calendars/default";
        private readonly ITestOutputHelper _output;

        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact, Priority(1)]
        public async void Test2Async()
        {
            Calendar calendar = await baseUrl.GetJsonAsync<Calendar>();
            calendar.Sanctorale.Language.Should().Be("en");
            _output.WriteLine("This is output from {0}", JsonConvert.SerializeObject(calendar));
        }

        [Fact, Priority(2)]
        public async Task Test1Async()
        {
            Calendar calendar = await baseUrl.GetJsonAsync<Calendar>();
            calendar.Sanctorale.Language.Should().Be("en");
            _output.WriteLine("This is output from {0}", 2);
        }

        [Fact, Priority(3)]
        public async Task Test3Async()
        {
            Calendar calendar = await baseUrl.GetJsonAsync<Calendar>();
            calendar.Sanctorale.Language.Should().Be("en");
            _output.WriteLine("This is output from {0}", 3);
        }
    }
}