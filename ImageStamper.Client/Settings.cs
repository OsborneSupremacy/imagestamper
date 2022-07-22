using System.ComponentModel.DataAnnotations;

namespace ImageStamper.Client;

public record Settings
{
    [Required]
    public List<string> SupportedImageTypes { get; set; } = default!;
}
