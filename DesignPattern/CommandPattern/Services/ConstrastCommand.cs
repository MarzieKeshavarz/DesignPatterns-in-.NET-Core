using DesignPattern.CommandPattern.FW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CommandPattern.Services
{
    public class ConstrastCommand : UndoableCommand
    {
        private VideoEditor _videoEditor { get; set; }
        private History _history { get; set; }

        private int prevContentContrast { get; set; }

        public ConstrastCommand(VideoEditor videoEditor, History history)
        {
            _videoEditor = videoEditor;
            _history = history;
        }

        public void execute()
        {
            prevContentContrast = _videoEditor.GetContrast();
            _videoEditor.AddContrast();
            _history.Push(this);
        }

        public void unExecute()
        {
            _videoEditor.SetContrast(prevContentContrast);
        }
    }
}
