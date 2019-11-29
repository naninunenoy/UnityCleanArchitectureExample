using UnityEngine;
using UniRx.Async;

namespace Example.Repository.Detail {
    public class PlayerPrefsCountDataStore : ICountDataStore {
        const string key = "count";

        UniTask<int> ICountDataStore.LoadCount() {
            return UniTask.FromResult(PlayerPrefs.GetInt(key, 0));
        }

        UniTask ICountDataStore.SaveCount(int count) {
            PlayerPrefs.SetInt(key, count);
            return UniTask.CompletedTask;
        }
    }
}
