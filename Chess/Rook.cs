using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Rook : IPiece
    {
        IPiece.Color color;
        public Rook(IPiece.Color color)
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
            for (int vert = 1; vert <= 7; vert++)
            {
                list.Add(new ProspectiveMove(vert, 0));
                list.Add(new ProspectiveMove(-vert, 0));
            }
            for (int hori = 1; hori <= 7; hori++)
            {
                list.Add(new ProspectiveMove(0, hori));
                list.Add(new ProspectiveMove(0, -hori));
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
