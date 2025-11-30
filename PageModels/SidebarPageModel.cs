using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Personal.Pages;
using Personal.Pages.MainMenu;
using Personal.Pages.Tools;
using Personal.Pages.System;

namespace Personal.PageModels
{
    public class SidebarPageModel : BasePageModel
    {
        public Action<Page> NavigateAction { get; set; }
        public SidebarPageModel() 
        {
            BuildCommands();
        }

        // Main Menu Commands
        public ICommand NavigateToDashboardCommand { get; private set; }
        public ICommand NavigateToOverviewCommand { get; private set; }

        // Tools Commands
        public ICommand NavigateToTools1Command { get; private set; }
        public ICommand NavigateToTools2Command { get; private set; }
        public ICommand NavigateToTools3Command { get; private set; }
        public ICommand NavigateToTools4Command { get; private set; }
        public ICommand NavigateToTools5Command { get; private set; }
        public ICommand NavigateToTools6Command { get; private set; }
        public ICommand NavigateToTools7Command { get; private set; }

        // System Commands
        public ICommand NavigateToUsersCommand { get; private set; }
        public ICommand NavigateToSettingsCommand { get; private set; }

        private void BuildCommands()
        {
            // Main Menu
            NavigateToDashboardCommand = new Command(() => NavigateAction?.Invoke(new DashboardPage()));
            NavigateToOverviewCommand = new Command(() => NavigateAction?.Invoke(new OverviewPage()));

            // Tools
            NavigateToTools1Command = new Command(() => NavigateAction?.Invoke(new Tools1Page()));
            NavigateToTools2Command = new Command(() => NavigateAction?.Invoke(new Tools2Page()));
            NavigateToTools3Command = new Command(() => NavigateAction?.Invoke(new Tools3Page()));
            NavigateToTools4Command = new Command(() => NavigateAction?.Invoke(new Tools4Page()));
            NavigateToTools5Command = new Command(() => NavigateAction?.Invoke(new Tools5Page()));
            NavigateToTools6Command = new Command(() => NavigateAction?.Invoke(new Tools6Page()));
            NavigateToTools7Command = new Command(() => NavigateAction?.Invoke(new Tools7Page()));

            // System
            NavigateToUsersCommand = new Command(() => NavigateAction?.Invoke(new UsersPage()));
            NavigateToSettingsCommand = new Command(() => NavigateAction?.Invoke(new SettingsPage()));
        }
    }
}
