using ImageStamper.Objects;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageStamper.Service;

public class BatchProcessor
{
    private readonly Processor _processor;

    private readonly ExifExtractor _exifExtractor;

    public BatchProcessor(Processor processor, ExifExtractor exifExtractor)
    {
        _processor = processor ?? throw new ArgumentNullException(nameof(processor));
        _exifExtractor = exifExtractor ?? throw new ArgumentNullException(nameof(exifExtractor));
    }

    public async Task ProcessAsync(BatchProcessSettings settings)
    {
        foreach (var imageFile in settings.ImageFiles)
        {
            using var bitmap = new Bitmap(imageFile.FullName);
            var text = await GetStampTextAsync(imageFile, settings.UseExif, settings.DefaultDateTime, settings.DateTimeFormatter);
            using var newBitmap = _processor.Process(bitmap, settings.Color, settings.BackGroundFill, settings.Font, text, settings.Position, settings.PercentOfImage);

            if (newBitmap == null)
                continue;

            newBitmap.Save(Path.Combine(settings.OutputDirectory.FullName, imageFile.Name), ImageFormat.Jpeg);
        }
    }

    private async Task<string> GetStampTextAsync(
        FileInfo imageFile,
        bool useExif,
        DateTime defaultDateTime,
        Func<DateTime, string> dateTimeFormatter
        )
    {
        DateTime? exifDate = null;

        if (useExif)
            exifDate = await _exifExtractor.ExtractDateAsync(imageFile.FullName);

        return dateTimeFormatter.Invoke(exifDate ?? defaultDateTime);
    }
}
