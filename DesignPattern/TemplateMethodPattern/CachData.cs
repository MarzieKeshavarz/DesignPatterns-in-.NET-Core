using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethodPattern
{
    public class CachData
    {
        public void ClearCach()
        {
            Console.WriteLine("Clearing Old GUI Cach");
        }
        public void AddCach()
        {
            Console.WriteLine("Adding New GUI Cach");
        }
    }
}
