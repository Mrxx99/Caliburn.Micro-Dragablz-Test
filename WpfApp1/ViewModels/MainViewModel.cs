using Caliburn.Micro;
using Dragablz;
using MahApps.Metro.Controls;
using System.Linq;
using System.Windows;
using WpfApp1.Views;

namespace WpfApp1.ViewModels
{
    public class MainViewModel : Conductor<IScreen>.Collection.OneActive
    {
        public MainViewModel()
        {
            Items.Add(new UserControl1ViewModel());
            Items.Add(new UserControl2ViewModel());
            ActivateItem(Items.Last());
        }
    }
}
