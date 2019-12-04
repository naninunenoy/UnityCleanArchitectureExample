using NUnit.Framework;
using UniRx;
using Example.Domain.Presenter;
using Example.Presenter;

namespace Example.Tests.EditMode {
    public class CountPresenterTest {
        ICountPresenter presenter;
        ICounterView view;

        [SetUp]
        public void SetUpTest() {
            view = new CountViewMock();
            presenter = new CountPresenter(view);
        }

        [Test]
        public void SetTextTest() {
            presenter.SetText("なにぬねの");
            Assert.AreEqual("なにぬねの", view.Text.text);
        }

        [Test]
        public void ButtonClickObservableText() {
            var cnt = 0;
            presenter
                .ButtonClickObservable
                .Subscribe(_ => {
                    cnt++;
                });
            view.Button.onClick.Invoke();
            Assert.AreEqual(1, cnt);
        }
    }
}
