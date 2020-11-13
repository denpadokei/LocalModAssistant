using Prism.Ioc;
using LocalModAssistant.Views;
using System.Windows;
using LocalModAssistant.Models;
using LocalModAssistant.Interfaces;
using Prism.Regions;

namespace LocalModAssistant
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ISetting, SettingEntity>();
            containerRegistry.RegisterDialog<Setting>();
            containerRegistry.Register<IMainDomain, MainViewDomain>();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            var rm = this.Container.Resolve<IRegionManager>();
            rm.RegisterViewWithRegion("ContentRegion", typeof(Main));
        }
    }
}
