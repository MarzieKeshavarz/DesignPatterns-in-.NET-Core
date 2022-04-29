using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.MementoPattern
{
    public class History
    {
        private List<EditorState> EditorStates = new List<EditorState>();

        public void Push(EditorState editorState)
        {
            EditorStates.Add(editorState);
        }

        public EditorState Pop()
        {
            var last = EditorStates[EditorStates.Count - 1];
            EditorStates.Remove(last);

            return last;
        }


    }
}
