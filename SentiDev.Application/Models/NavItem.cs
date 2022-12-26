namespace SentiDev.Application.Models;

public record NavItem
{
    public string Text { get; init; } = string.Empty;
    public string Href { get; init; } = string.Empty;
}