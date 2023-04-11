using System;
using System.Reactive;
using BubblesDivePlanner.Controllers;
using Example.ViewModels.Models;
using ReactiveUI;

namespace Example.ViewModels
{
    public class MainWindowViewModel : ReactiveObject, IMainWindowModel
    {
        public MainWindowViewModel()
        {
            PrintTextCommand = ReactiveCommand.Create(PrintText, CanPrintText);
        }

        private IClickMeModel clickMe = new ClickMeViewModel();
        public IClickMeModel ClickMe
        {
            get => clickMe;
            set => this.RaiseAndSetIfChanged(ref clickMe, value);
        }

        private IClickMeModel clickMeResult = new ClickMeViewModel();
        public IClickMeModel ClickMeResult
        {
            get => clickMeResult;
            set => this.RaiseAndSetIfChanged(ref clickMeResult, value);
        }

        public ReactiveCommand<Unit, Unit> PrintTextCommand { get; }
        public IObservable<bool> CanPrintText
        {
            get => this.WhenAnyValue(vm => vm.ClickMe.SomeText,
                (someText) => !string.IsNullOrWhiteSpace(someText));
        }

        private void PrintText()
        {
            ClickMeResult.SomeText = new ClickMeController().GetSomeText(ClickMe);
        }
    }
}