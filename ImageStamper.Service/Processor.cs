using ImageStamper.Objects;
using System.Drawing;

namespace ImageStamper.Service
{
    public class Processor
    {
        // TODO: use ems for padding, rather than pixesls
        private const int _padPixels = 2;

        private readonly ImageConverter _imageConverter;

        private readonly DrawingService _drawingService;

        private readonly StampSizeService _stampSizeService;

        private readonly BoundaryCalculator _boundaryCalculator;

        private readonly CoordinatesService _coordinatesService;

        public Processor(
            ImageConverter imageConverter,
            DrawingService drawingService,
            StampSizeService stampSizeService,
            BoundaryCalculator boundaryCalculator,
            CoordinatesService coordinatesService
            )
        {
            _imageConverter = imageConverter ?? throw new ArgumentNullException(nameof(imageConverter));
            _drawingService = drawingService ?? throw new ArgumentNullException(nameof(drawingService));
            _stampSizeService = stampSizeService ?? throw new ArgumentNullException(nameof(stampSizeService));
            _boundaryCalculator = boundaryCalculator ?? throw new ArgumentNullException(nameof(boundaryCalculator));
            _coordinatesService = coordinatesService ?? throw new ArgumentNullException(nameof(coordinatesService));
        }

        public Bitmap Process(
            Bitmap bitmap,
            Color color,
            bool backGroundFill,
            Font fontIn,
            string text,
            PositionConstants position,
            int percentOfImage
            )
        {
            using var imgGrphx = _imageConverter.BitmapToGraphics(bitmap);

            var imageSize = new SizeF(bitmap.Width, bitmap.Height);

            SolidBrush brush = new(color);

            var (stampSize, stampFont)  = _stampSizeService.GetStampSize(imageSize, imgGrphx, text, fontIn, percentOfImage);
            var boundaries = _boundaryCalculator.Calculate(imageSize, stampSize, _padPixels);
            var coordinates = _coordinatesService.Get(position, boundaries);

            if (backGroundFill)
                _drawingService.DrawBackground(imgGrphx, coordinates, stampSize);

            _drawingService.DrawStamp(imgGrphx, brush, stampFont, text, coordinates);

            return bitmap;
        }

    }
}