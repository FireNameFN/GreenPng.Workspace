using ImageMagick;

namespace GreenPng.Tests;

public static class Decoders {
    public static byte[] DecodeGreenPng(byte[] png) {
        return PngDecoder.Decode(png, out _);
    }

    public static byte[] DecodeImageMagick(byte[] png) {
        using MagickImage magick = new(png);

        return magick.ToByteArray(MagickFormat.Bgra);
    }

    public static byte[] DecodeStbImageSharpBgra(byte[] png) {
        byte[] image = StbImageSharp.ImageResult.FromMemory(png, StbImageSharp.ColorComponents.RedGreenBlueAlpha).Data;

        for(int i = 0; i < image.Length; i += 4)
            (image[i], image[i + 2]) = (image[i + 2], image[i]);

        return image;
    }

    public static byte[] DecodeStbImageSharpRgba(byte[] png) {
        return StbImageSharp.ImageResult.FromMemory(png, StbImageSharp.ColorComponents.RedGreenBlueAlpha).Data;
    }
}
