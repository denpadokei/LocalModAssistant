using Prism.Mvvm;

namespace LocalModAssistant.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Local Mod Assistant";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
