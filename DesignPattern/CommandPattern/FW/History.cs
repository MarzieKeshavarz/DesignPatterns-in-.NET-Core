using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CommandPattern.FW
{
    public class History
    {
        private List<UndoableCommand> undoCommands = new List<UndoableCommand>();


        public void Push(UndoableCommand undoCommand)
        {
            undoCommands.Add(undoCommand);
        }

        public UndoableCommand Pop()
        {
            var item = undoCommands[undoCommands.Count - 1];
            undoCommands.RemoveAt(undoCommands.Count - 1);
            return item;
        }


        public int Size()
        {
            return undoCommands.Count;
        }
    }
}
