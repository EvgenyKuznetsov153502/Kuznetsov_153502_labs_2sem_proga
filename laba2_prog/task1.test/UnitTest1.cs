using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using static task1.Program;

namespace task1.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string s = "������ ����� ������";
            Assert.Equal(s, message(8, 2));


        }

        [Fact]
        public void Test2()
        {
            string s = "������ ����� ������";
            Assert.Equal(s, message(5, 6));


        }

        [Fact]
        public void Test3()
        {
            string s = "������ ����� ����� ���������";
            Assert.Equal(s, message(3, 3));

        }



    }
}
