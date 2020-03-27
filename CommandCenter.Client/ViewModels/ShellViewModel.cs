using CommandCenter.Client.Views;
using Prism.Mvvm;
using Prism.Regions;
using System.Windows;

namespace CommandCenter.Client.ViewModels
{
    public class ShellViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        private string _title = "Command Center";

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public ShellViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _regionManager.RegisterViewWithRegion(Regions.Content, typeof(ProgressView));
        }
    }
}