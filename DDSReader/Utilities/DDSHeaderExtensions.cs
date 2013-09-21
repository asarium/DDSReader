using DDSReader.Internal;

namespace DDSReader.Utilities
{
    public static class DDSHeaderExtensions
    {
        public static bool Is3DTexture(this DDSHeader header)
        {
            return header.dwFlags.HasFlag(DDSD.DEPTH);
        }

        public static bool HasMipmaps(this DDSHeader header)
        {
            return header.dwFlags.HasFlag(DDSD.MIPMAPCOUNT);
        }

        public static uint MipmapCount(this DDSHeader header)
        {
            return !header.HasMipmaps() ? 1 : header.dwMipMapCount;
        }

        public static uint TextureDepth(this DDSHeader header)
        {
            return !header.Is3DTexture() ? 1 : header.dwDepth;
        }

        public static uint Width(this DDSHeader header)
        {
            return header.dwWidth;
        }

        public static uint Height(this DDSHeader header)
        {
            return header.dwWidth;
        }
    }
}