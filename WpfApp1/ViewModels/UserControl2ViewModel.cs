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
    public partial class UserControl2ViewModel : Screen
    {

        public UserControl2ViewModel()
        {
            DisplayName = "b";
        }

        protected override void OnActivate()
        {
            base.OnActivate();
        }
    }
}
