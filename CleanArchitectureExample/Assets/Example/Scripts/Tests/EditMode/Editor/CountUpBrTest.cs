using NUnit.Framework;
using Example.Domain;

namespace Example.Tests.EditMode {
    public class CountUpBrTest {

        CountUpBr countUp;
        CountVo count;

        [SetUp]
        public void SetUpTest() {
            countUp = new CountUpBr(10);
            count = new CountVo(0);
        }

        [Test]
        public void CountUpTest() {
            Assert.AreEqual(1, countUp.CountUp(count));
            Assert.AreEqual(2, countUp.CountUp(count));
            Assert.AreEqual(3, countUp.CountUp(count));
            Assert.AreEqual(4, countUp.CountUp(count));
            Assert.AreEqual(5, countUp.CountUp(count));
            Assert.AreEqual(6, countUp.CountUp(count));
            Assert.AreEqual(7, countUp.CountUp(count));
            Assert.AreEqual(8, countUp.CountUp(count));
            Assert.AreEqual(9, countUp.CountUp(count));
            Assert.AreEqual(10, countUp.CountUp(count));
            Assert.AreEqual(10, countUp.CountUp(count));
        }
    }
}
