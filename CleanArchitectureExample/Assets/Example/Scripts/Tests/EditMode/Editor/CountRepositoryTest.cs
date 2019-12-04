using NUnit.Framework;
using Example.Domain.Repository;
using Example.Repository;

namespace Example.Tests.EditMode {
    public class CountRepositoryTest {

        ICountRepository repository;

        [SetUp]
        public void SetUpTest() {
            repository = new CountRepository(new CountDataStoreMock());
        }


        // A Test behaves as an ordinary method
        [Test]
        public void SetGetTest() {
            repository.SetCountAsync(100).GetResult();
            var cnt = repository.GetCountAsync().Result;
            Assert.AreEqual(100, cnt);
        }
    }
}
