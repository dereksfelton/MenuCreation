using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPair
{
    public Vector4 Dark { get; set; }
    public Vector4 Light { get; set; }
}

public static class TextPalette
{
    public static readonly Dictionary<string, ColorPair> Color = new Dictionary<string, ColorPair>()
    {
        { "Red",      new ColorPair() { Light = new Vector4(0.37500f, 0.00000f, 0.00000f, 1), Dark = new Vector4( 1.00000f, 0.75000f, 0.75000f, 1) } },
        { "Green",    new ColorPair() { Light = new Vector4(0.00000f, 0.28125f, 0.00000f, 1), Dark = new Vector4( 0.75000f, 1.00000f, 0.75000f, 1) } },
        { "Blue",     new ColorPair() { Light = new Vector4(0.00000f, 0.00000f, 0.37500f, 1), Dark = new Vector4( 0.75000f, 0.75000f, 1.00000f, 1) } },
        { "Yellow",   new ColorPair() { Light = new Vector4(0.25000f, 0.25000f, 0.00000f, 1), Dark = new Vector4( 1.00000f, 1.00000f, 0.07500f, 1) } },
        { "Purple",   new ColorPair() { Light = new Vector4(0.25000f, 0.00000f, 0.25000f, 1), Dark = new Vector4( 1.00000f, 0.75000f, 1.00000f, 1) } },
        { "Gray",     new ColorPair() { Light = new Vector4(0.06250f, 0.06250f, 0.06250f, 1), Dark = new Vector4( 0.93750f, 0.93750f, 0.93750f, 1) } },
        { "Backdrop", new ColorPair() { Light = new Vector4(1.00000f, 1.00000f, 1.00000f, 0.875f), Dark = new Vector4( 0.00000f, 0.00000f, 0.00000f, 0.875f) } }
    };
}