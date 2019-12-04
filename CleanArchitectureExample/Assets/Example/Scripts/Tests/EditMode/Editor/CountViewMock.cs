using UnityEngine;
using UnityEngine.UI;
using Example.Presenter;

namespace Example.Tests.EditMode {
    public class CountViewMock : ICounterView {
        readonly GameObject gameObject = new GameObject();
        public Button Button =>
            gameObject.GetComponent<Button>() ?? gameObject.AddComponent<Button>();
        public Text Text =>
            gameObject.GetComponent<Text>() ?? gameObject.AddComponent<Text>();
    }
}
