using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CommandPattern.FW
{
    public interface UndoableCommand : Command 
    {
        void unExecute();
    }
}
