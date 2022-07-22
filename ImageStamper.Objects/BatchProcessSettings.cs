using System.Drawing;

namespace ImageStamper.Objects;

public record BatchProcessSettings
{
    public BatchProcessSettings(
        IEnumerable<FileInfo> imageFiles,
        DirectoryInfo outputDirectory,
        Color color,
        bool backGroundFill,
        Font font,
        bool useExif,
        DateTime defaultDateTime,
        Func<DateTime, string> dateTimeFormatter,
        PositionConstants position,
        int percentOfImage
        )
    {
        ImageFiles = imageFiles ?? throw new ArgumentNullException(nameof(imageFiles));
        OutputDirectory = outputDirectory ?? throw new ArgumentNullException(nameof(outputDirectory));
        Color = color;
        BackGroundFill = backGroundFill;
        Font = font ?? throw new ArgumentNullException(nameof(font));
        UseExif = useExif;
        DefaultDateTime = defaultDateTime;
        DateTimeFormatter = dateTimeFormatter ?? throw new ArgumentNullException(nameof(dateTimeFormatter));
        Position = position;
        PercentOfImage = percentOfImage;
    }

    public IEnumerable<FileInfo> ImageFiles { get; set; }

    public DirectoryInfo OutputDirectory { get; set; }

    public Color Color { get; set; }

    public bool BackGroundFill { get; set; }

    public Font Font { get; set; }

    public bool UseExif { get; set; }

    public DateTime DefaultDateTime { get; set; }

    public Func<DateTime, string> DateTimeFormatter { get; set; }

    public PositionConstants Position { get; set; }

    public int PercentOfImage { get; set; }
}
