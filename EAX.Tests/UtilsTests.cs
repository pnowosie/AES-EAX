using System.Linq;
using Shouldly;

namespace EAX.Tests
{
    public class UtilsTests
    {
        public void HexToBytesConvertion()
        {
            var bytes = Enumerable.Range(0, 0xff).Select(i => (byte)i).ToArray();
            var hex = string.Join("", Enumerable.Range(0, 0xff).Select(b => b.ToString("X2")));

            var hexCnvrt = Utils.Bytes2Hex(bytes);
            hexCnvrt.ShouldBe(hex);

            var byteCnvrt = Utils.Hex2Bytes(hexCnvrt);
            byteCnvrt.ShouldBe(bytes);
        }
    }
}