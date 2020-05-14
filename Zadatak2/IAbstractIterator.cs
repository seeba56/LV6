using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    interface IAbstractIterator
    {
        Product First();
        Product Next();
        bool isDone { get; }
        Product Current { get; }
    }
}
