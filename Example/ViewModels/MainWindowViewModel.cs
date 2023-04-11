using Example.ViewModels;
using Example.ViewModels.Models;
using ReactiveUI;

namespace Example.ViewModels
{
    public class MainWindowViewModel : ReactiveObject, IMainWindowModel
    {
        private IClickMeViewModel clickMeViewModel = new ClickMeViewModel();
        public IClickMeViewModel ClickMeViewModel
        {
            get => clickMeViewModel;
            set => this.RaiseAndSetIfChanged(ref clickMeViewModel, value);
        }
    }
}