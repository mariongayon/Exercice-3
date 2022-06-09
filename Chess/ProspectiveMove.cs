using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public struct ProspectiveMove : IMove
    {
        public int vertical;
        public int horizontal;

        public ProspectiveMove(int vertical, int horizontal)
        {
            this.vertical = vertical;
            this.horizontal = horizontal;
        }
    }
}
