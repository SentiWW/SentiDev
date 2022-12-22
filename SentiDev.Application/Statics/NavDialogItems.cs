using System.Collections.ObjectModel;

namespace SentiDev.Application.Statics;

public static class NavDialogItems
{
    public static readonly Collection<NavItem> Items = new ()
    {
        new ()
        {
            Text = "Lorem",
            Href = "https://www.google.com/"
        },
        new ()
        {
            Text = "Ipsum",
            Href = "https://www.google.com/"
        },
        new ()
        {
            Text = "Dolor",
            Href = "https://www.google.com/"
        }
    };
}

public record NavItem
{
    public string Text { get; init; }
    public string Href { get; init; }
}