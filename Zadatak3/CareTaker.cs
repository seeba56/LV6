using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class CareTaker
    {
        private List<Memento> previousState;
        private int i;

        public CareTaker()
        {
            this.previousState = new List<Memento>();
            i = previousState.Count - 1;
        }

        public CareTaker(List<Memento> previousState)
        {
            this.previousState = previousState;
            i = previousState.Count - 1;
        }
        public Memento Remove()
        {
            --i;
            if (i < 0) return null;
            return previousState[i];
        }
        public void AddPreviousState(Memento state)
        {
            previousState.Add(state);
            i = previousState.Count - 1;
        }

        public Memento Add()
        {
            ++i;
            if (i > previousState.Count - 1) return null;
            return previousState[i];
        }

    }
}
