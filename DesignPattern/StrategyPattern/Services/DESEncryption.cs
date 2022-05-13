using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StrategyPattern
{
    public class DESEncryption : Encryption
    {
        public void Encrypt(string txt)
        {
            Console.WriteLine("DES Encryption: " + txt);
        }
    }
}
