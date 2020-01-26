using Caliburn.Micro;
using Dragablz;
using MahApps.Metro.Controls;
using System.Linq;
using System.Windows;
using WpfApp1.Views;

namespace WpfApp1.ViewModels
{
    public class MainViewModel : Conductor<IScreen>.Collection.OneActive, IInterTabClient
    {

        public MainViewModel()
        {
            Items.Add(new UserControl1ViewModel());
            Items.Add(new UserControl2ViewModel());
            ActivateItem(Items.Last());
        }

        private MainViewModel(bool dontstart)
        {

        }

        public INewTabHost<Window> GetNewHost(IInterTabClient interTabClient, object partition, TabablzControl source)
        {
            var shell = new MainView();
            shell.Title = DisplayName;
            var vm = new MainViewModel(true);

            ViewModelBinder.Bind(vm, shell, null);
            return new NewTabHost<MetroWindow>(shell, shell.Items);
        }

        public TabEmptiedResponse TabEmptiedHandler(TabablzControl tabControl, Window window)
        {
            return TabEmptiedResponse.CloseWindowOrLayoutBranch;
        }
    }
}
