using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CommandPattern
{
    public class VideoEditor
    {
        private bool HasLabel { get; set; }
        private int Contrast { get; set; }


        public void AddLabel()
        {
            HasLabel = true;
            Console.WriteLine("add label");
        }

        public void AddContrast()
        {
            Contrast = ++Contrast;
            Console.WriteLine("add one to contrast");
        }

        public bool GetHasLabel()
        {
            return HasLabel;
        }

        public void SetHasLabel(bool hasLabel)
        {
            HasLabel = hasLabel;
        }

        public int GetContrast()
        {
            return Contrast;
        }

        public void SetContrast(int contrast)
        {
            Contrast = contrast;
        }

    }
}
