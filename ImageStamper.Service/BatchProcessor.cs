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

    public async Task ProcessAsync(BatchProcessArgs args)
    {
        foreach (var imageFile in args.ImageFiles)
        {
            using var bitmap = new Bitmap(imageFile.FullName);
            var text = await GetStampTextAsync(args, imageFile);

            using var newBitmap = _processor.Process(
                new(bitmap, args.Color, args.BackGroundFill,
                    new(args.FontArgs, text)
                )
            );

            if (newBitmap == null)
                continue;

            newBitmap.Save(Path.Combine(args.OutputDirectory.FullName, imageFile.Name), ImageFormat.Jpeg);
        }
    }

    private async Task<string> GetStampTextAsync(BatchProcessArgs args, FileInfo imageFile)
    {
        DateTime? exifDate = null;

        if (args.UseExif)
            exifDate = await _exifExtractor.ExtractDateAsync(imageFile.FullName);

        return args.DateTimeFormatter(exifDate ?? args.DefaultDateTime);
    }
}
