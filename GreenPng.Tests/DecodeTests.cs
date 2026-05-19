using System;
using System.Linq;
using System.Threading.Tasks;
using GreenPng.Testing;

namespace GreenPng.Tests;

public sealed class DecodeTests {
    [Test]
    [MethodDataSource(typeof(TestImageDataSource), nameof(TestImageDataSource.GetTestImages))]
    public async Task EqualToStbImageSharp(TestImage testImage) {
        byte[] image = Decoders.DecodeGreenPng(testImage.Png);

        byte[] imageRef = Decoders.DecodeStbImageSharpBgra(testImage.Png);

        await Assert.That(image.SequenceEqual(imageRef)).IsTrue();
    }
}
