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

        private readonly BrushService _brushService;

        private readonly StampSizeService _stampSizeService;

        private readonly BoundaryCalculator _boundaryCalculator;

        private readonly CoordinatesService _coordinatesService;

        public Processor(
            ImageConverter imageConverter,
            DrawingService drawingService,
            BrushService brushService,
            StampSizeService stampSizeService,
            BoundaryCalculator boundaryCalculator,
            CoordinatesService coordinatesService
            )
        {
            _imageConverter = imageConverter ?? throw new ArgumentNullException(nameof(imageConverter));
            _drawingService = drawingService ?? throw new ArgumentNullException(nameof(drawingService));
            _brushService = brushService ?? throw new ArgumentNullException(nameof(brushService));
            _stampSizeService = stampSizeService ?? throw new ArgumentNullException(nameof(stampSizeService));
            _boundaryCalculator = boundaryCalculator ?? throw new ArgumentNullException(nameof(boundaryCalculator));
            _coordinatesService = coordinatesService ?? throw new ArgumentNullException(nameof(coordinatesService));
        }

        public Bitmap Process(
            Bitmap bitMapIn,
            string colorName,
            Font font,
            string text,
            PositionConstants position,
            double targetWidth
            )
        {
            var bitMapOut = (Bitmap)bitMapIn.Clone();

            using var imgGrphx = _imageConverter.BitmapToGraphics(bitMapOut);

            var brush = _brushService.GetSolidBrush(colorName);

            var stampSize = _stampSizeService.GetStampSize(imgGrphx, text, font, targetWidth);

            var boundaries = _boundaryCalculator.Calculate(bitMapIn.Width, bitMapIn.Height, stampSize.Width, stampSize.Height, _padPixels);

            var coordinates = _coordinatesService.Get(position, boundaries);

            _drawingService.DrawStamp(imgGrphx, brush, font, text, coordinates);

            return bitMapOut;
        }

    }
}