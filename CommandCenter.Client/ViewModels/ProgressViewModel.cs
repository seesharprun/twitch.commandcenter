using Prism.Mvvm;
using CommandCenter.Services;
using Prism.Regions;

namespace CommandCenter.Client.ViewModels
{
    public class ProgressViewModel : BindableBase, INavigationAware
    {
        private readonly CommandService _commandService;

        public bool ShowChat
        {
            get => _commandService.Chat;
            set {
                _commandService.Chat = value;
            }
        }

        public bool ShowPrep
        {
            get => _commandService.Prep;
            set
            {
                _commandService.Prep = value;
            }
        }

        public bool ShowCode
        {
            get => _commandService.Code;
            set
            {
                _commandService.Code = value;
            }
        }

        public bool ShowWrap
        {
            get => _commandService.Wrap;
            set
            {
                _commandService.Wrap = value;
            }
        }

        public ProgressViewModel(CommandService commandService)
        {
            _commandService = commandService;
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
        }

        public bool IsNavigationTarget(NavigationContext navigationContext) => true;

        public void OnNavigatedFrom(NavigationContext navigationContext)
        { 
        
        }
    }
}