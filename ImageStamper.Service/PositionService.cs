using ImageStamper.Objects;

namespace ImageStamper.Service
{
    public class PositionService
    {
        public Dictionary<PositionConstants, Coordinate> GetPositionDictionary(
            double xLeft,
            double xCenter,
            double xRight,
            double yTop,
            double yCenter,
            double yBottom
            ) => new()
            {
                { PositionConstants.BottomLeft, new(xLeft, yBottom) },
                { PositionConstants.BottomCenter, new(xCenter, yBottom) },
                { PositionConstants.BottomRight, new(xRight, yBottom) },
                { PositionConstants.CenterLeft, new(xLeft, yCenter) },
                { PositionConstants.CenterCenter, new(xCenter, yCenter) },
                { PositionConstants.CenterRight, new(xRight, yCenter) },
                { PositionConstants.TopLeft, new(xLeft, yTop) },
                { PositionConstants.TopCenter, new(xCenter, yTop) },
                { PositionConstants.TopRight, new(xRight, yTop) }
            };

    }
}
