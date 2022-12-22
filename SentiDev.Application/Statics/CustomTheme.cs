using MudBlazor;

namespace SentiDev.Application.Statics;

public static class CustomTheme
{
    public static readonly MudTheme Theme = new ()
    {
        Palette = new ()
        {
            Primary = Colors.Red.Darken2
        },
        PaletteDark = new ()
        {
            Primary = Colors.Red.Darken2
        }
    };
}