using DesignPattern.CommandPattern.FW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CommandPattern.Services
{
    public class LabelCommand : UndoableCommand
    {
        private VideoEditor _videoEditor { get; set; }
        private History _history { get; set; }

        private bool prevContentHasLabel = false;

        public LabelCommand(VideoEditor videoEditor, History history)
        {
            _videoEditor = videoEditor;
            _history = history;
        }

        public void execute()
        {
            prevContentHasLabel = _videoEditor.GetHasLabel();
            _videoEditor.AddLabel();
            _history.Push(this);
        }

        public void unExecute()
        {
            _videoEditor.SetHasLabel(prevContentHasLabel);
        }
    }
}
