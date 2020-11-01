using System;
using System.Drawing;
using System.Globalization;
using System.IO;


namespace MelfColorTest
{
    class ImageService
    {

        public Image GetImage()
        {
            var s = File.ReadAllText(@"C:\Users\vardan.saakian\source\repos\ImageConverter\TextFile1.txt");
            if (s.StartsWith("0x"))
            s = s.Remove(0, 2);
            using (var stream = new MemoryStream(ConvertHexStringToByteArray(s)))
            {
                var image = new Bitmap(stream);
                return image;
            }
        }

        public static byte[] ConvertHexStringToByteArray(string hexString)
        {
            if (hexString.Length % 2 != 0)
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", hexString));
            }

            byte[] HexAsBytes = new byte[hexString.Length / 2];
            for (int index = 0; index < HexAsBytes.Length; index++)
            {
                string byteValue = hexString.Substring(index * 2, 2);
                HexAsBytes[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }

            return HexAsBytes;
        }
    }
}
