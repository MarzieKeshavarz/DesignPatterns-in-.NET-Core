using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.MementoPattern
{
    public class Editor
    {
        private string Content;
        private string FontName;
        private string FontSize;
        private History history = new History();

        public void CreateState()
        {
            history.Push(new EditorState(Content, FontName, FontSize));
        }

        public void UndoContent()
        {
            var state = history.Pop();
            Content = state.GetContent();
        }

        public void UndoFontName()
        {
            var state = history.Pop();
            FontName = state.GetFontName();
        }

        public void UndoFontSize()
        {
            var state = history.Pop();
            FontSize = state.GetFontSize();
        }


        public string GetContent()
        {
            return Content;
        }

        public void SetContent(string Content)
        {
            this.Content = Content;
        }

        public string GetFontName()
        {
            return FontName;
        }

        public void SetFontName(string FontName)
        {
            this.FontName = FontName;
        }

        public string GetFontSize()
        {
            return FontSize;
        }

        public void SetFontSize(string FontSize)
        {
            this.FontSize = FontSize;
        }

    }
}
