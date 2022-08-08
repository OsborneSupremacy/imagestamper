using System.Drawing;

namespace ImageStamper.Objects;

public record BatchProcessSettings
{
    public BatchProcessSettings(
        IEnumerable<FileInfo> imageFiles,
        DirectoryInfo outputDirectory,
        Color color,
        bool backGroundFill,
        bool useExif,
        DateTime defaultDateTime,
        Func<DateTime, string> dateTimeFormatter,
        FontArgs fontArgs
        )
    {
        ImageFiles = imageFiles ?? throw new ArgumentNullException(nameof(imageFiles));
        OutputDirectory = outputDirectory ?? throw new ArgumentNullException(nameof(outputDirectory));
        Color = color;
        BackGroundFill = backGroundFill;
        UseExif = useExif;
        DefaultDateTime = defaultDateTime;
        DateTimeFormatter = dateTimeFormatter ?? throw new ArgumentNullException(nameof(dateTimeFormatter));
        FontArgs = fontArgs ?? throw new ArgumentNullException(nameof(fontArgs));
    }

    public IEnumerable<FileInfo> ImageFiles { get; set; }

    public DirectoryInfo OutputDirectory { get; set; }

    public Color Color { get; set; }

    public bool BackGroundFill { get; set; }

    public bool UseExif { get; set; }

    public DateTime DefaultDateTime { get; set; }

    public Func<DateTime, string> DateTimeFormatter { get; set; }

    public FontArgs FontArgs { get; set; }
}
