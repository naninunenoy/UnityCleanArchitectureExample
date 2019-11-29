using UniRx.Async;
using CleanArchtecture;

namespace Example.Domain.Repository {
    public interface ICountRepository : IRepository {
        UniTaskVoid SetCountAsync(int count);
        UniTask<int> GetCountAsync();
    }
}
