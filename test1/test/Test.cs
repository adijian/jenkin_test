using NUnit.Framework;

namespace test1.test
{
    public class Tester
    {
        [Test]
        public async Task TestPass()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public async Task TestFail()
        {
            Assert.IsTrue(false);
        }
    }
}