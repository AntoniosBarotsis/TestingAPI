using System.Threading.Tasks;
using FakeItEasy;
using src.Services;
using Xunit;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var myDependency = new MyDependency();
            Assert.Equal("Hello From MyDependency!", await myDependency.GetDataFromDatabaseAsync());
        }
        
        [Fact]
        public async Task Test2()
        {
            var myDependency = A.Fake<IMyDependency>();
            A.CallTo(() => myDependency.GetDataFromDatabaseAsync()).Returns(Task.FromResult("Hello from mocked"));
            
            Assert.Equal("Hello from mocked", await myDependency.GetDataFromDatabaseAsync());
        }
    }
}