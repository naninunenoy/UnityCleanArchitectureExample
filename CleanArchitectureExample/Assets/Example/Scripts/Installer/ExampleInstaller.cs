using UnityEngine;
using Zenject;
using Example.Domain.Presenter;
using Example.Domain.Repository;
using Example.Presenter;
using Example.Repository;
using Example.Presenter.Detail;
using Example.Repository.Detail;

namespace Example.Installer {
    public class ExampleInstaller : MonoInstaller, IInstaller {
        [SerializeField] CounterView view = default;

        public override void InstallBindings() {
            Container
                .Bind<ICountPresenter>()
                .FromInstance(new CountPresenter(view))
                .AsCached();
            Container
                .Bind<ICountRepository>()
                .FromInstance(new CountRepository(new PlayerPrefsCountDataStore()))
                .AsCached();
        }

        [ContextMenu("reset count")]
        void DeleteCountKey() {
            PlayerPrefs.DeleteKey(PlayerPrefsCountDataStore.Key);
        }
    }
}
