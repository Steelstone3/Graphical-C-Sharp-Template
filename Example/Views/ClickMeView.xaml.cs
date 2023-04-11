using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Example.Views
{
    public class ClickMeView : UserControl
    {
        public ClickMeView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
