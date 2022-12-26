using System.Collections.ObjectModel;
using SentiDev.Application.Models;

namespace SentiDev.Application.Statics;

public static class NavDialogItems
{
    public static readonly Collection<NavItem> Items = new ()
    {
        new NavItem
        {
            Text = "Home",
            Href = Routes.HomeRoute
        },
        new NavItem
        {
            Text = "About Me",
            Href = Routes.AboutMeRoute
        },
        new NavItem
        {
            Text = "Projects",
            Href = Routes.ProjectsRoute
        },
        new NavItem
        {
            Text = "Contact",
            Href = Routes.ContactRoute
        }
    };
}