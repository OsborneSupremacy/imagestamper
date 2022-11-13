namespace ImageStamper.Service;

public class CoordinatesService
{
    public Coordinates Get(
        PositionConstants position,
        Boundaries boundaries
        ) =>
        position switch
        {
            PositionConstants.BottomLeft => new(boundaries.Left, boundaries.Bottom),
            PositionConstants.BottomXCenter => new(boundaries.XCenter, boundaries.Bottom),
            PositionConstants.BottomRight => new(boundaries.Right, boundaries.Bottom),
            PositionConstants.YCenterLeft => new(boundaries.Left, boundaries.YCenter),
            PositionConstants.YCenterXCenter => new(boundaries.XCenter, boundaries.YCenter),
            PositionConstants.YCenterRight => new(boundaries.Right, boundaries.YCenter),
            PositionConstants.TopLeft => new(boundaries.Left, boundaries.Top),
            PositionConstants.TopXCenter => new(boundaries.XCenter, boundaries.Top),
            PositionConstants.TopRight => new(boundaries.Right, boundaries.Top),
            _ => throw new NotImplementedException(),
        };
}
