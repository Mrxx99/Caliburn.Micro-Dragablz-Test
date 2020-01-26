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
    public class UserControl1ViewModel : Screen
    {
        public UserControl1ViewModel()
        {
            DisplayName = "a";
        }

        protected override void OnActivate()
        {
            base.OnActivate();
        }
    }
}
