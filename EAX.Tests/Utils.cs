using System;
using System.Linq;

namespace EAX.Tests
{
    public class Utils
    {
        public static byte[] Hex2Bytes(string hexString)
        {
            if (hexString.Length % 2 != 0)
                throw new ArgumentException("Hex string length have to be even.");
            return Enumerable.Range(0, hexString.Length/2)
                .Select(i => Convert.ToByte(hexString.Substring(i*2, 2), 16))
                .ToArray();
        }

        public static string Bytes2Hex(byte[] bytes)
        {
            return string.Join("", bytes.Select(b => b.ToString("X2")));
        }
    }
}