using UniRx.Async;
using CleanArchtecture;

namespace Example.Domain.Repository {
    public interface ICountRepository : IRepository {
        UniTask SetCountAsync(int count);
        UniTask<int> GetCountAsync();
    }
}
