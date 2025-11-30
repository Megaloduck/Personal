using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using Font = Microsoft.Maui.Font;
using CommunityToolkit.Mvvm.Input;
using Personal.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Personal
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Start the app at LoginPage
            GoToAsync("//LoginPage");
        }
    }
}