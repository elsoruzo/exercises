using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace XUnitTestProjectOserverPattern
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Program program = new Program();
            Program.Main(new string[0]);
            
        }
    }
}
