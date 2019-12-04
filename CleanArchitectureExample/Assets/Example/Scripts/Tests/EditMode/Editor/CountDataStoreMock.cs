using Example.Repository;
using UniRx.Async;

namespace Example.Tests.EditMode {
    public class CountDataStoreMock : ICountDataStore {
        int count = 0;

        public UniTask<int> LoadCount() {
            return UniTask.FromResult(count);
        }

        public UniTask SaveCount(int count) {
            this.count = count;
            return UniTask.CompletedTask;
        }
    }
}
