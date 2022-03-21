using ImageStamper.Objects;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageStamper.Service
{
    public class BatchProcessor
    {
        private readonly Processor _processor;

        private readonly ExifExtractor _exifExtractor;

        public BatchProcessor(Processor processor, ExifExtractor exifExtractor)
        {
            _processor = processor ?? throw new ArgumentNullException(nameof(processor));
            _exifExtractor = exifExtractor ?? throw new ArgumentNullException(nameof(exifExtractor));
        }

        public async Task ProcessAsync(
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
            foreach (var imageFile in imageFiles)
            {
                using var bitmap = new Bitmap(imageFile.FullName);
                var text = await GetStampTextAsync(imageFile, useExif, defaultDateTime, dateTimeFormatter);
                using var newBitmap = _processor.Process(bitmap, color, backGroundFill, font, text, position, percentOfImage);

                if (newBitmap == null)
                    continue;

                newBitmap.Save(Path.Combine(outputDirectory.FullName, imageFile.Name), ImageFormat.Jpeg);
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
}
