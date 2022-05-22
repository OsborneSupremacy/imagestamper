namespace ImageStamper.Objects;

public struct Coordinates
{
    public Coordinates(float x, float y)
    {
        X = x;
        Y = y;
    }

    public float X { get; set; }

    public float Y { get; set; }
}
