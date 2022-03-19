using ImageStamper.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Process(
            IEnumerable<FileInfo> imageFiles,
            DirectoryInfo outputDirectory,
            Color color,
            bool backGroundFill,
            Font font,
            bool useExif,
            string defaultText,
            PositionConstants position,
            int percentOfImage)
        {
            foreach(var imageFile in imageFiles)
            {
                var bitmap = new Bitmap(imageFile.FullName);

                // need to be able to format
                if(useExif)
                {
                    var stampText = _exifExtractor.ExtractDateAsync(imageFile.FullName);
                }

                var newFile = _processor.Process(bitmap, color, backGroundFill, font, defaultText, position, percentOfImage);
            }
        }
    }
}
