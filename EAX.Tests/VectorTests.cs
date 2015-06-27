using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace EAX.Tests
{
    public class VectorTests
    {
        public void Vector0()
        {
            var Key = Utils.Hex2Bytes("233952DEE4D5ED5F9B9C6D6FF80FF478");
            var Nonce = Utils.Hex2Bytes("62EC67F9C3A4A407FCB2A8C49031A8B3");
            var Head = Utils.Hex2Bytes("6BFB914FD07EAE6B");
            var Cipher = "E037830E8389F27B025A2D6527E79D01";

            var CT = CryptoUtils.EAX(Key, Head, Nonce, new byte[0]);

            CT.ShouldBe(Utils.Hex2Bytes(Cipher));
        }

        public void Vector1()
        {
            var Msg = Utils.Hex2Bytes("F7FB");
            var Key = Utils.Hex2Bytes("91945D3F4DCBEE0BF45EF52255F095A4");
            var Nonce = Utils.Hex2Bytes("BECAF043B0A23D843194BA972C66DEBD");
            var Head = Utils.Hex2Bytes("FA3BFD4806EB53FA");
            var Cipher = "19DD5C4C9331049D0BDAB0277408F67967E5";

            var CT = CryptoUtils.EAX(Key, Head, Nonce, Msg);

            CT.ShouldBe(Utils.Hex2Bytes(Cipher));
        }

        public void Vector2()
        {
            var Msg = Utils.Hex2Bytes("1A47CB4933");
            var Key = Utils.Hex2Bytes("01F74AD64077F2E704C0F60ADA3DD523");
            var Nonce = Utils.Hex2Bytes("70C3DB4F0D26368400A10ED05D2BFF5E");
            var Head = Utils.Hex2Bytes("234A3463C1264AC6");
            var Cipher = "D851D5BAE03A59F238A23E39199DC9266626C40F80";

            var CT = CryptoUtils.EAX(Key, Head, Nonce, Msg);

            CT.ShouldBe(Utils.Hex2Bytes(Cipher));
        }

        public void Vector3()
        {
            var Msg = Utils.Hex2Bytes("481C9E39B1");
            var Key = Utils.Hex2Bytes("D07CF6CBB7F313BDDE66B727AFD3C5E8");
            var Nonce = Utils.Hex2Bytes("8408DFFF3C1A2B1292DC199E46B7D617");
            var Head = Utils.Hex2Bytes("33CCE2EABFF5A79D");
            var Cipher = "632A9D131AD4C168A4225D8E1FF755939974A7BEDE";

            var CT = CryptoUtils.EAX(Key, Head, Nonce, Msg);

            CT.ShouldBe(Utils.Hex2Bytes(Cipher));
        }

        public void Vector4()
        {
            var Msg = Utils.Hex2Bytes("40D0C07DA5E4");
            var Key = Utils.Hex2Bytes("35B6D0580005BBC12B0587124557D2C2");
            var Nonce = Utils.Hex2Bytes("FDB6B06676EEDC5C61D74276E1F8E816");
            var Head = Utils.Hex2Bytes("AEB96EAEBE2970E9");
            var Cipher = "071DFE16C675CB0677E536F73AFE6A14B74EE49844DD";

            var CT = CryptoUtils.EAX(Key, Head, Nonce, Msg);

            CT.ShouldBe(Utils.Hex2Bytes(Cipher));
        }

        public void Vector5()
        {
            var Msg = Utils.Hex2Bytes("4DE3B35C3FC039245BD1FB7D");
            var Key = Utils.Hex2Bytes("BD8E6E11475E60B268784C38C62FEB22");
            var Nonce = Utils.Hex2Bytes("6EAC5C93072D8E8513F750935E46DA1B");
            var Head = Utils.Hex2Bytes("D4482D1CA78DCE0F");
            var Cipher = "835BB4F15D743E350E728414ABB8644FD6CCB86947C5E10590210A4F";

            var CT = CryptoUtils.EAX(Key, Head, Nonce, Msg);

            CT.ShouldBe(Utils.Hex2Bytes(Cipher));
        }

        public void Vector6()
        {
            var Msg = Utils.Hex2Bytes("8B0A79306C9CE7ED99DAE4F87F8DD61636");
            var Key = Utils.Hex2Bytes("7C77D6E813BED5AC98BAA417477A2E7D");
            var Nonce = Utils.Hex2Bytes("1A8C98DCD73D38393B2BF1569DEEFC19");
            var Head = Utils.Hex2Bytes("65D2017990D62528");
            var Cipher = "02083E3979DA014812F59F11D52630DA30137327D10649B0AA6E1C181DB617D7F2";

            var CT = CryptoUtils.EAX(Key, Head, Nonce, Msg);

            CT.ShouldBe(Utils.Hex2Bytes(Cipher));
        }

        public void Vector7()
        {
            var Msg = Utils.Hex2Bytes("1BDA122BCE8A8DBAF1877D962B8592DD2D56");
            var Key = Utils.Hex2Bytes("5FFF20CAFAB119CA2FC73549E20F5B0D");
            var Nonce = Utils.Hex2Bytes("DDE59B97D722156D4D9AFF2BC7559826");
            var Head = Utils.Hex2Bytes("54B9F04E6A09189A");
            var Cipher = "2EC47B2C4954A489AFC7BA4897EDCDAE8CC33B60450599BD02C96382902AEF7F832A";

            var CT = CryptoUtils.EAX(Key, Head, Nonce, Msg);

            CT.ShouldBe(Utils.Hex2Bytes(Cipher));
        }

        public void Vector8()
        {
            var Msg = Utils.Hex2Bytes("6CF36720872B8513F6EAB1A8A44438D5EF11");
            var Key = Utils.Hex2Bytes("A4A4782BCFFD3EC5E7EF6D8C34A56123");
            var Nonce = Utils.Hex2Bytes("B781FCF2F75FA5A8DE97A9CA48E522EC");
            var Head = Utils.Hex2Bytes("899A175897561D7E");
            var Cipher = "0DE18FD0FDD91E7AF19F1D8EE8733938B1E8E7F6D2231618102FDB7FE55FF1991700";

            var CT = CryptoUtils.EAX(Key, Head, Nonce, Msg);

            CT.ShouldBe(Utils.Hex2Bytes(Cipher));
        }

        public void Vector9()
        {
            var Msg = Utils.Hex2Bytes("CA40D7446E545FFAED3BD12A740A659FFBBB3CEAB7");
            var Key = Utils.Hex2Bytes("8395FCF1E95BEBD697BD010BC766AAC3");
            var Nonce = Utils.Hex2Bytes("22E7ADD93CFC6393C57EC0B3C17D6B44");
            var Head = Utils.Hex2Bytes("126735FCC320D25A");
            var Cipher = "CB8920F87A6C75CFF39627B56E3ED197C552D295A7CFC46AFC253B4652B1AF3795B124AB6E";

            var CT = CryptoUtils.EAX(Key, Head, Nonce, Msg);

            CT.ShouldBe(Utils.Hex2Bytes(Cipher));
        }
    }

    public class CryptoUtils
    {
        public static object EAX(byte[] key, byte[] head, byte[] nonce, byte[] msg)
        {
            throw new NotImplementedException();
        }
    }
}
