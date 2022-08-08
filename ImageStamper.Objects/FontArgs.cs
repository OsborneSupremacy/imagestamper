﻿using System.Drawing;

namespace ImageStamper.Objects;

public record FontArgs
{
    public FontArgs(string text, Font font, int percentOfImage, PositionConstants position)
    {
        Text = text ?? throw new ArgumentNullException(nameof(text));
        Font = font ?? throw new ArgumentNullException(nameof(font));
        PercentOfImage = percentOfImage;
        Position = position;
    }

    public string Text { get; set; }

    public Font Font { get; set; }

    public int PercentOfImage { get; set; }

    public PositionConstants Position { get; set; }
}
