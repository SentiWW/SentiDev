using Microsoft.AspNetCore.Components;
using MudBlazor;
using SentiDev.Application.Components.NavScreen;

namespace SentiDev.Application.Shared;

public partial class MainLayout
{
    [Inject]
    private IDialogService DialogService { get; set; } = null!;
    
    private async Task DrawerToggleAsync()
    {
        await DialogService.ShowAsync<NavScreen>(string.Empty, new DialogOptions
        {
            CloseButton = false,
            CloseOnEscapeKey = true,
            FullScreen = true, 
            FullWidth = true
        });
    }
}