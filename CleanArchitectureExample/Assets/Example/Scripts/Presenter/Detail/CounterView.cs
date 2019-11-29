using UnityEngine;
using UnityEngine.UI;

namespace Example.Presenter.Detail {
    public class CounterView : MonoBehaviour, ICounterView {
        [SerializeField] Button button = default;
        [SerializeField] Text text = default;

        Button ICounterView.Button => button;
        Text ICounterView.Text => text;
    }
}
