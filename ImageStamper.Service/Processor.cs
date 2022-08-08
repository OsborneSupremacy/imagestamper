using System.Drawing;
using ImageStamper.Objects;

namespace ImageStamper.Service;

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

    public Bitmap? Process(ProcessArgs args)
    {
        using var imgGrphx = _imageConverter.BitmapToGraphics(args.Bitmap);
        if (imgGrphx == null) return null;

        var imageSize = new SizeF(args.Bitmap.Width, args.Bitmap.Height);

        SolidBrush brush = new(args.Color);

        var (stampSize, stampFont) = _stampSizeService.GetStampSize(imageSize, imgGrphx, args.Text, args.Font, args.PercentOfImage);
        var boundaries = _boundaryCalculator.Calculate(imageSize, stampSize, _padPixels);
        var coordinates = _coordinatesService.Get(args.Position, boundaries);

        if (args.BackgroundFill)
            _drawingService.DrawBackground(imgGrphx, coordinates, stampSize);

        _drawingService.DrawStamp(imgGrphx, brush, stampFont, args.Text, coordinates);

        return args.Bitmap;
    }

}
