# ImageTools-PCL

ImageTools for Silverlight made compatible with PCL. See http://imagetools.codeplex.com/ for information.

## Changes

	JpegDecoder is now capable of decoding `Grayscale` images.

## Recommendations

Avoid using the JPEG decoder and encoder. The quality of the used libraries is terrible. It is quite common to extract an image and have over 400MB RAM in use. I have ported NanoJPEG, a C JPEG decompression library, to C#. It is much better in both performance and memory, but is lacking progressive JPEG support. If you still want to use that implementation, use JpegDecoderNano.