using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CleanArchtecture;
using UniRx.Async;

namespace Example.Repository {
    public interface ICountDataStore : IDataStore {
        UniTask<int> LoadCount();
        UniTask SaveCount(int count);
    }
}
