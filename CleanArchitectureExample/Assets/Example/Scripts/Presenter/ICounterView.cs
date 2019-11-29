using UnityEngine.UI;
using CleanArchtecture;

namespace Example.Presenter {
    public interface ICounterView : IView {
        Button Button { get; }
        Text Text { get; }
    }
}
