namespace Personal.Pages;

public partial class SidebarPage : ContentPage
{
    private readonly SidebarPageModel _pageModel;

    public SidebarPage()
    {
        InitializeComponent();

        _pageModel = new SidebarPageModel();
        _pageModel.NavigateAction = NavigateToPage;
        BindingContext = _pageModel;

        // Load initial page
        _pageModel.NavigateToDashboardCommand.Execute(null);
    }

    private void NavigateToPage(Page page)
    {
        ContentArea.Content = page;
    }
}