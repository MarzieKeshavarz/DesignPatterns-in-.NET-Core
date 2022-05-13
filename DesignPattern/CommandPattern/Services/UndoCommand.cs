using DesignPattern.CommandPattern.FW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CommandPattern.Services
{
    public class UndoCommand : Command
    {
        private History _history { get; set; }

        public UndoCommand(History history)
        {
            _history = history;
        }

        public void execute()
        {
            if (_history.Size() > 0)
                _history.Pop().unExecute();
        }
    }
}
