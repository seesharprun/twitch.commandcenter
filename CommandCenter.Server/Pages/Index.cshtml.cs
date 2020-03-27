using CommandCenter.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CommandCenter.Server.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CommandService _commandService;

        public IndexModel(CommandService commandService)
        {
            _commandService = commandService;
        }

        [BindProperty]
        public bool ShowChat
        {
            get => _commandService.Chat;
        }

        [BindProperty]
        public bool ShowPrep
        {
            get => _commandService.Prep;
        }

        [BindProperty]
        public bool ShowCode
        {
            get => _commandService.Code;
        }

        [BindProperty]
        public bool ShowWrap
        {
            get => _commandService.Wrap;
        }

        public void OnGet()
        {
        }
    }
}