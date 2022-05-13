using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StrategyPattern
{
    public class AESEncryption : Encryption
    {
        public void Encrypt(string txt)
        {
            Console.WriteLine("AES Encryption: " + txt);
        }
    }
}
