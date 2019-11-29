using System;
using UniRx;
using Example.Domain.Presenter;

namespace Example.Presenter {
    public class CountPresenter : ICountPresenter {
        readonly ICounterView view;

        public CountPresenter(ICounterView view) {
            this.view = view;
        }
        IObservable<Unit> ICountPresenter.ButtonClickObservable => view.Button.OnClickAsObservable();

        void ICountPresenter.SetText(string text) {
            view.Text.text = text;
        }
    }
}
