using Example.ViewModels.Models;
using ReactiveUI;

namespace Example.ViewModels
{
    public class ClickMeViewModel : ReactiveObject, IClickMeViewModel
    {
        private string someText = string.Empty;
        public string SomeText
        {
            get => someText;
            set => this.RaiseAndSetIfChanged(ref someText, value);
        }
    }
}