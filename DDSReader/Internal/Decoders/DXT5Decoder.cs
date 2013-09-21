#region Usings

using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using DDSReader.Utilities;

#endregion

namespace DDSReader.Internal.Decoders
{
    public class DXT5Decoder : DXTDecoder
    {
        public DXT5Decoder(DDSHeader header) : base(header)
        {
        }

        public override async Task<byte[]> DecodeFrame(Stream dataSource, uint width, uint height)
        {
            var totalSize = Header.Width() * Header.Height() * BytesPerPixel;

            var frameData = new byte[totalSize];

            return frameData;
        }
    }
}
