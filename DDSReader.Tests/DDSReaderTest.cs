#region Usings

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using NUnit.Framework;

#endregion

namespace DDSReader.Tests
{
    [TestFixture]
    public class DDSReaderTest
    {
        [Test]
        public async Task TestReadImageAsync()
        {
            var image = await DDSReader.ReadImageAsync(@"G:\Programme\FreeSpace\Diaspora\Data\maps\Col_BS_Sobek_Per.dds");

            var bitmapSource = await image.Frames.First().ToBitmapSource();

            using (var fileStream = new FileStream(@"F:\temp\test.png", FileMode.OpenOrCreate))
            {
                var encoder = new PngBitmapEncoder {Frames = new List<BitmapFrame> {BitmapFrame.Create(bitmapSource)}};

                encoder.Save(fileStream);
            }
        }
    }
}
