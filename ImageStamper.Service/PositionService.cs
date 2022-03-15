using ImageStamper.Objects;

namespace ImageStamper.Service
{
    public class PositionService
    {
        public Dictionary<PositionConstants, Coordinates> GetPositionDictionary(Boundaries boundaries) => 
            new()
            {
                { PositionConstants.BottomLeft, new(boundaries.Left, boundaries.Bottom) },
                { PositionConstants.BottomXCenter, new(boundaries.XCenter, boundaries.Bottom) },
                { PositionConstants.BottomRight, new(boundaries.Right, boundaries.Bottom) },
                { PositionConstants.YCenterLeft, new(boundaries.Left, boundaries.YCenter) },
                { PositionConstants.YCenterXCenter, new(boundaries.XCenter, boundaries.YCenter) },
                { PositionConstants.YCenterRight, new(boundaries.Right, boundaries.YCenter) },
                { PositionConstants.TopLeft, new(boundaries.Left, boundaries.Top) },
                { PositionConstants.TopXCenter, new(boundaries.XCenter, boundaries.Top) },
                { PositionConstants.TopRight, new(boundaries.Right, boundaries.Top) }
            };
    }
}
