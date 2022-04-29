using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.MementoPattern
{
    public class EditorState
    {
        private string Content;
        private string FontName;
        private string FontSize;

        public EditorState(string content, string fontName, string fontSize)
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
        }

        public string GetContent()
        {
            return Content;
        }

        public string GetFontName()
        {
            return FontName;
        }

        public string GetFontSize()
        {
            return FontSize;
        }

    }
}
