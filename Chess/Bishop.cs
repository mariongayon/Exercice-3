using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Bishop : IPiece
    {
        IPiece.Color color;
        public Bishop(IPiece.Color color)
        {
            this.color = color;
        }

        public bool CanCastle()
        {
            return false;
        }

        public bool CanSkip()
        {
            return false;
        }

        public List<ProspectiveMove> Capabilities()
        {
            List<ProspectiveMove> list = new List<ProspectiveMove>();
            for (int diag = 1; diag <= 7; diag++)
            {
                list.Add(new ProspectiveMove(diag, diag));
                list.Add(new ProspectiveMove(-diag, -diag));
                list.Add(new ProspectiveMove(-diag, diag));
                list.Add(new ProspectiveMove(diag, -diag));
            }
            return list;
        }

        public IPiece.Color GetColor()
        {
            return color;
        }

        public bool IsPawn()
        {
            return false;
        }
    }
}

