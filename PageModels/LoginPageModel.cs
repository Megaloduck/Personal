using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Personal.Pages;
using Personal.Pages.MainMenu;
using Personal.Pages.Tools;
using Personal.Pages.System;

namespace Personal.PageModels
{   
    public partial class LoginPageModel :ObservableObject
    {
        public IRelayCommand LoginCommand { get; }
        public LoginPageModel() 
        {
            LoginCommand = new RelayCommand(OnLogin);
        }
        private async void OnLogin()
        {
            await Shell.Current.GoToAsync("SidebarPage");
        }
    }
}
