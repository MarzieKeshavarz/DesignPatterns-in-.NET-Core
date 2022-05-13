using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StrategyPattern
{
    public class TextEncryption
    {
        private string Text { get; set; }
        private Encryption _Encryption { get; set; }

        public TextEncryption(Encryption encryption)
        {
            _Encryption = encryption;
        }

        public void Encrypt(string text)
        {
            _Encryption.Encrypt(text);
        }

        public string GetText()
        {
            return Text;
        }

        public void SetText(string text)
        {
            Text = text;
        }
    }
}
