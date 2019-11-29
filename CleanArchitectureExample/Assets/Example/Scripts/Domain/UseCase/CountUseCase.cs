using System;
using UniRx;
using UniRx.Async;
using CleanArchtecture;
using Example.Domain.Presenter;
using Example.Domain.Repository;

namespace Example.Domain.UseCase {
    public sealed class CountUseCase : IUseCase {
        readonly ICountPresenter presenter;
        readonly ICountRepository repository;
        readonly CompositeDisposable disposables;
        readonly CountUpBr counter;

        public CountUseCase(ICountPresenter presenter, ICountRepository repository) {
            this.presenter = presenter;
            this.repository = repository;
            disposables = new CompositeDisposable();
            counter = new CountUpBr(Constants.MaxCount);
        }

        async void IUseCase.Begin() {
            var init = await repository.GetCountAsync();
            presenter.SetText($"{init}");
            var count = new CountVo(init);
            presenter
                .ButtonClickObservable
                .Subscribe(async _ => {
                    var oldCount = count.Count;
                    var newCount = counter.CountUp(count);
                    if (oldCount != newCount) {
                        presenter.SetText($"{newCount}");
                        await repository.SetCountAsync(newCount);
                    }
                })
                .AddTo(disposables);
        }

        void IUseCase.Finish() {
            disposables.Dispose();
        }
    }
}
