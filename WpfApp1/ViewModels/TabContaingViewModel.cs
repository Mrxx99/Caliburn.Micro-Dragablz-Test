using Caliburn.Micro;

namespace WpfApp1.ViewModels
{
    public partial class UserControl2ViewModel
    {
        public class TabContaingViewModel
        {
            public IObservableCollection<Screen> Items { get; } = new BindableCollection<Screen>();
        }
    }
}
