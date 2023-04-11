using Example.ViewModels;
using Example.ViewModels.Models;
using ReactiveUI;

namespace Example.ViewModels
{
    public class MainWindowViewModel : ReactiveObject, IMainWindowModel
    {
        private IClickMeViewModel clickMe = new ClickMeViewModel();
        public IClickMeViewModel ClickMe
        {
            get => clickMe;
            set => this.RaiseAndSetIfChanged(ref clickMe, value);
        }
    }
}