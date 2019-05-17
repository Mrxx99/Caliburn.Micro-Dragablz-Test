using Caliburn.Micro;
using Dragablz;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Views;

namespace WpfApp1.ViewModels
{
    public class UserControl2ViewModel : Screen, IInterTabClient
    {

        public UserControl2ViewModel()
        {
            DisplayName = "2";
        }

        public INewTabHost<Window> GetNewHost(IInterTabClient interTabClient, object partition, TabablzControl source)
        {
            var shell = new MainView();
            shell.Title = DisplayName;
            var vm = IoC.Get<UserControl2ViewModel>();

            ViewModelBinder.Bind(vm, shell, null);
            return new NewTabHost<MetroWindow>(shell, shell.Items);
        }

        public TabEmptiedResponse TabEmptiedHandler(TabablzControl tabControl, Window window)
        {
            return TabEmptiedResponse.DoNothing;
        }
    }
}
