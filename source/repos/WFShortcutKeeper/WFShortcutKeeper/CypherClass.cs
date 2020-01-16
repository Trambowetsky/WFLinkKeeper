using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFShortcutKeeper
{
    public static class CypherClass
    {
        public static string XORCipher(string data, string key)
        {
            byte[] arr = Encoding.UTF8.GetBytes(data);
            int dataLen = arr.Length;
            int keyLen = key.Length;
            byte[] output = new byte[dataLen];
            try
            {
                for (int i = 0; i < dataLen; ++i)
                {
                    output[i] = (byte)(data[i] ^ key[i % keyLen]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Використовуйте будь ласка тільки латинські літери. У посиланнях та описі");
            };
            return Encoding.UTF8.GetString(output);
        }
    }
}
