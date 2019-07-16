using Caliburn.Micro;
using QUANLYTHUVIEN.ViewModels;
using System.Windows;

namespace QUANLYTHUVIEN
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MenuViewModel>();
        }

    }
}
