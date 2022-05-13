using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethodPattern
{
    public class HomeWindow : Close
    {
        public HomeWindow(CachData cachData) : base(cachData) { }

        protected override void _CloseWindow()
        {
            Console.WriteLine("Closing Home Window GUI");
        }
    }
}
