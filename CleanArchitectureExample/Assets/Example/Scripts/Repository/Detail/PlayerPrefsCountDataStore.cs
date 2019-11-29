using UnityEngine;
using UniRx.Async;

namespace Example.Repository.Detail {
    public class PlayerPrefsCountDataStore : ICountDataStore {
        public const string Key = "count";

        UniTask<int> ICountDataStore.LoadCount() {
            return UniTask.FromResult(PlayerPrefs.GetInt(Key, 0));
        }

        UniTask ICountDataStore.SaveCount(int count) {
            PlayerPrefs.SetInt(Key, count);
            return UniTask.CompletedTask;
        }
    }
}
