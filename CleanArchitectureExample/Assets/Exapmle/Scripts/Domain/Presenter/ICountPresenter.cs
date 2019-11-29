using System;
using UniRx;
using CleanArchtecture;

namespace Example.Domain.Presenter {
    public interface ICountPresenter : IPresenter {
        IObservable<Unit> ButtonClickObservable { get; }
        void SetText(string text);
    }
}
