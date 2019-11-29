using UnityEngine;
using Zenject;
using CleanArchtecture;
using Example.Domain.UseCase;
using Example.Domain.Presenter;
using Example.Domain.Repository;

namespace Example.Main {
    public sealed class ExampleMain : MonoBehaviour, IMain {
        IUseCase usecase;

        [Inject]
        void ConstructUseCases(ICountPresenter presenter, ICountRepository repository) {
            usecase = new CountUseCase(presenter, repository);
        }

        void Awake() {
            usecase.Begin();
        }

        void OnDestroy() {
            usecase.Finish();
        }
    }
}
