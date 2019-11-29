using UniRx.Async;
using Example.Domain.Repository;

namespace Example.Repository {
    public class CountRepository : ICountRepository {
        readonly ICountDataStore dataStore;

        public CountRepository(ICountDataStore dataStore) {
            this.dataStore = dataStore;
        }

        UniTask<int> ICountRepository.GetCountAsync() {
            return dataStore.LoadCount();
        }

        UniTask ICountRepository.SetCountAsync(int count) {
            return dataStore.SaveCount(count);
        }
    }
}
