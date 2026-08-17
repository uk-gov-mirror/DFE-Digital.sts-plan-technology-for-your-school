using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace Dfe.PlanTech.Core.Contentful.Models;

[ExcludeFromCodeCoverage]
public class RedirectEntry : ContentfulEntry
{
    public string InternalName { get; set; } = null!;
    public string RedirectFrom { get; init; } = null!;
    public string RedirectTo { get; init; } = null!;
    public IEnumerable<string> RedirectFromList =>
        Regex
            .Split(RedirectFrom, @"[\n\r]+", RegexOptions.Compiled)
            .Select(stem => stem[1..].Trim());
}
