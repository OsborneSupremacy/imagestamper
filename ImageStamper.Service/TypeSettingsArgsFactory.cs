namespace ImageStamper.Service;
public class TypeSettingsArgsFactory
{
    // TODO: use ems for padding, rather than pixels
    private const int PadPixels = 2;

    private readonly StampSizeService _stampSizeService;

    private readonly BoundaryCalculator _boundaryCalculator;

    private readonly CoordinatesService _coordinatesService;

    public TypeSettingsArgsFactory(
        StampSizeService stampSizeService,
        BoundaryCalculator boundaryCalculator,
        CoordinatesService coordinatesService
        )
    {
        _stampSizeService = stampSizeService ?? throw new ArgumentNullException(nameof(stampSizeService));
        _boundaryCalculator = boundaryCalculator ?? throw new ArgumentNullException(nameof(boundaryCalculator));
        _coordinatesService = coordinatesService ?? throw new ArgumentNullException(nameof(coordinatesService));
    }

    public TypeSettingsArgs Create(ProcessArgs args, Graphics image)
    {
        var imageSize = new SizeF(args.Bitmap.Width, args.Bitmap.Height);

        SolidBrush brush = new(args.Color);

        StampSizeArgs stampSizeArgs =
            new(imageSize, image, args.TypographyArgs);

        var (stampSize, stampFont) = _stampSizeService.GetStampSize(stampSizeArgs);
        var boundaries = _boundaryCalculator.Calculate(new(imageSize, stampSize, PadPixels));
        var coordinates = _coordinatesService.Get(args.TypographyArgs.Position, boundaries);

        return new(args.TypographyArgs, brush, coordinates, stampFont, stampSize);
    }
}
