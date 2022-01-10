using Xunit;
using SerialLog;

namespace UnitTest
{
    public class UnitTest1
    {
        private SerialLogger _test = new SerialLogger();
        
        [Fact]
        public void Startup_Arguments_Wrong()
        {
            Assert.False(true);
        }
    }
}