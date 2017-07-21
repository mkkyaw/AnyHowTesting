using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyHowTesting
{
    public delegate void NumberReachedtHandler(object sender, NumberReachedEventArgs e);

    public class Counter
    {
        public event NumberReachedtHandler NumberReached;

        public void CountTo(int countTo, int reachNum)
        {
            if (countTo == reachNum)
            {
                var arg = new NumberReachedEventArgs(reachNum);
                OnCounterReached(arg);
            }
        }

        public void OnCounterReached(NumberReachedEventArgs e)
        {
            NumberReached(this, e);
        }
    }

    public class NumberReachedEventArgs : EventArgs
    {

        private int _reached;
        public NumberReachedEventArgs(int num)
        {
            this._reached = num;
        }
        public int ReachedNumber
        {
            get
            {
                return _reached;
            }
        }
    }
}
