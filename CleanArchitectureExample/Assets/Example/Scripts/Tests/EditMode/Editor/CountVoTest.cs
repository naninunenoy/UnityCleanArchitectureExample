using NUnit.Framework;

namespace Example.Tests.EditMode {
    public class CountVoTest {
        CountVo count;

        [Test]
        public void CountTest() {
            count = new CountVo(100);
            Assert.AreEqual(100, count.Count);
            count.Add();
            Assert.AreEqual(101, count.Count);
        }
    }
}
