using System.Collections.ObjectModel;
using MudBlazor;
using SentiDev.Application.Models;

namespace SentiDev.Application.Statics;

public static class SocialsItems
{
    public static readonly Collection<SocialsItem> Items = new ()
    {
        new SocialsItem
        {
            Icon = Icons.Custom.Brands.GitHub,
            Title = "GitHub",
            Href = "https://github.com/SentiWW"
        },
        new SocialsItem
        {
            Icon = Icons.Material.Filled.Mail,
            Title = "Mail",
            Href = "mailto:contact@senti.dev"
        }
    };
}

