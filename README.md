# GreenPng

Fastest PNG decoder for .NET designed to be blazingly fast and memory efficient.

It is focused on decoding 8-bit-per-channel images to little-endian `BGRA` format (like `VK_FORMAT_B8G8R8A8_SRGB` or `SDL_PIXELFORMAT_ARGB8888`).

## Comparsion

| Project | Speed | Memory Efficiency | Free License |
|-|-|-|-|
| **GreenPng** | :zap: | :green_circle: | :white_check_mark: |
| StbImageSharp | :bulb: | :yellow_circle:| :white_check_mark: |
| Magick.NET | :snowflake: | :yellow_circle: | :white_check_mark: |
| SixLabors.ImageSharp | :bulb: | :yellow_circle: | :x: |

## Format support

| Type | 1, 2, 4 Bit | 8 Bit | 16 Bit |
|-|-|-|-|
| Greyscale | :white_check_mark: | :white_check_mark: | :x: |
| Truecolor || :white_check_mark: | :x: |
| Indexed | :white_check_mark: | :white_check_mark: | :x: |
| Indexed (with transparency) | :white_check_mark: | :white_check_mark: | :x: |
| Greyscale with alpha || :white_check_mark: | :x: |
| Truecolor with alpha || :white_check_mark: | :x: |

## How to use

### Installing from NuGet

[![nuget](https://img.shields.io/nuget/v/GreenPng)](https://www.nuget.org/packages/GreenPng)

```sh
dotnet add package GreenPng
```

### Easy use

```cs
byte[] image = PngDecoder.Decode(pngFileData, out PngHeader header);

int width = header.Width;
int height = header.Height;
```

### More advanced way

```cs
bool ok = PngDecoder.TryDecodeHeader(pngFileData, out PngHeader header);

ok = PngDecoder.IsHeaderSupported(header);

byte[] image = new byte[header.ByteSize];

ok = PngDecoder.TryDecode(pngFileData, header, image);
```

## Not supported

- Interlacing
- 16 bit
- Unusual chunks
- War

## Git Workspace

This is **workspace** of Git Workspace paradigm.<br>
Main component: [GreenPng](github.com/ProtoFN/GreenPng)<br>
Components:
- [GreenPng](github.com/ProtoFN/GreenPng)
- [GreenBuf](https://github.com/ProtoFN/GreenBuf)
