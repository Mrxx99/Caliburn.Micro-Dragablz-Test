using Caliburn.Micro;
using Dragablz;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Views;

namespace WpfApp1.ViewModels
{
    public class UserControl1ViewModel : Screen, IInterTabClient
    {
        public UserControl1ViewModel()
        {
            DisplayName = "1";
        }

        public INewTabHost<Window> GetNewHost(IInterTabClient interTabClient, object partition, TabablzControl source)
        {
            var shell = new MainView();
            shell.Title = this.DisplayName;
            //shell.InitializeComponent(); // Only required if you don't have ShellView.xaml.cs
            var vm = IoC.Get<UserControl1ViewModel>();

            ViewModelBinder.Bind(vm, shell, null);
            return new NewTabHost<MetroWindow>(shell, shell.Items);
        }

        public TabEmptiedResponse TabEmptiedHandler(TabablzControl tabControl, Window window)
        {
            return TabEmptiedResponse.CloseWindowOrLayoutBranch;
        }
    }
}
