using Microsoft.AspNetCore.Components;
using MudBlazor;
using SentiDev.Application.Components;

namespace SentiDev.Application.Shared;

public partial class MainLayout
{
    [Inject]
    private IDialogService DialogService { get; set; } = null!;
    
    private async Task DrawerToggleAsync()
    {
        await DialogService.ShowAsync<NavDialog>(string.Empty, new DialogOptions
        {
            CloseButton = true,
            CloseOnEscapeKey = true,
            FullScreen = true, 
            FullWidth = true
        });
    }
}