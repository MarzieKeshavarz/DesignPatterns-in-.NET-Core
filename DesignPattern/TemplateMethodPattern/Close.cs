using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethodPattern
{
    public abstract class Close
    {
        private CachData _cachData { get; set; }
       
        public Close()
        {
            _cachData = new CachData();
        }
        public Close(CachData cachData)
        {
            _cachData = cachData;
        }

        public void CloseWindow()
        {
            _cachData.ClearCach();
            _CloseWindow();
            _cachData.AddCach();
        }

        protected abstract void _CloseWindow();

    }
}
