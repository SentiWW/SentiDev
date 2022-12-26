namespace SentiDev.Application.Models;

public record SocialsItem
{
    public string Icon { get; init; } = string.Empty;
    public string Title { get; init; } = string.Empty;
    public string Href { get; init; } = string.Empty;
}