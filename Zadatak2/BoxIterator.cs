﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    class BoxIterator : IAbstractIterator
    {
        private Box box;
        private int currentPosition;
        public BoxIterator(Box box)
        {
            this.box = box;
            this.currentPosition = 0;
        }
        public bool isDone { get { return this.currentPosition >= this.box.Count; } }
        public Product Current { get { return this.box[this.currentPosition]; } }
        public Product First() { return this.box[0]; }
        public Product Next()
        {
            this.currentPosition++;
            if (this.isDone)
            {
                return null;
            }
            else
            {
                return this.box[this.currentPosition];
            }
        }

    }
}
