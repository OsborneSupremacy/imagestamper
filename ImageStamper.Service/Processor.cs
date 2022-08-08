using System.Drawing;
using ImageStamper.Objects;

namespace ImageStamper.Service;

public class Processor
{
    private readonly ImageConverter _imageConverter;

    private readonly DrawingService _drawingService;

    private readonly TypeSettingsArgsFactory _typeSettingsArgsFactory;

    public Processor(
        ImageConverter imageConverter,
        DrawingService drawingService,
        TypeSettingsArgsFactory typeSettingsArgsFactory
        )
    {
        _imageConverter = imageConverter ?? throw new ArgumentNullException(nameof(imageConverter));
        _drawingService = drawingService ?? throw new ArgumentNullException(nameof(drawingService));
        _typeSettingsArgsFactory = typeSettingsArgsFactory ?? throw new ArgumentNullException(nameof(typeSettingsArgsFactory));
    }

    public Bitmap? Process(ProcessArgs args)
    {
        using var imgGrphx = _imageConverter.BitmapToGraphics(args.Bitmap);
        if (imgGrphx == null) return null;

        var typeSettingsArgs = _typeSettingsArgsFactory.Create(args, imgGrphx);

        if (args.BackgroundFill)
            _drawingService.DrawBackground(imgGrphx, typeSettingsArgs);

        _drawingService.DrawStamp(imgGrphx, typeSettingsArgs);
        return args.Bitmap;
    }
}
