using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class LegalMove : IMove
    {
        IPiece piece;
        Tuple<int, int> source;
        Tuple<int, int> destination;

        public LegalMove(IPiece piece, Tuple<int, int> source, Tuple<int, int> destination)
        {
            this.piece = piece;
            this.source = source;
            this.destination = destination;
        }
    }
}
