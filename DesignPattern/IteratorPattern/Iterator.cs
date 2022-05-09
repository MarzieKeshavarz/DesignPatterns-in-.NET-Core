using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.IteratorPattern
{
    public interface Iterator<T>
    {
        void GetNext();

        T Current();

        bool HasNext();

    }
}
