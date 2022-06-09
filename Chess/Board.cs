using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
	/// <summary>
	/// Represente un plateau d'echecs.
	/// 
	/// Sur notre échéquier, on a les positions representees comme des <c>Tuple&lt;int,int&gt;</c>. 
	/// Un mouvement positif vertical c'est vers les pions noirs, un mouvement positif 
	/// horizontal c'est de la reine vers le roi. L'origine est la case en bas a gauche (0,0)
	/// </summary>
	public class Board
	{
		/// <summary>
		/// C'est la liste des pieces
		/// </summary>
		public Dictionary<Tuple<int, int>, IPiece> pieces;

		public Board()
        {
			pieces = new Dictionary<Tuple<int, int>, IPiece>();
		}

		public List<LegalMove> LegalMovesFrom(Tuple<int, int> position)
		{
			return LegalMoves(position, pieces[position]);
		}

		List<LegalMove> LegalMoves(Tuple<int, int> position, IPiece piece)
        {
			List<LegalMove> returnMoves = new List<LegalMove>();
			var listMoves = piece.Capabilities();
			for(int index = 0; index < listMoves.Count; index++)
            {
				IPiece destination;
				Tuple<int, int> positionDestination;
				positionDestination = new Tuple<int,int>(
					position.Item1 + listMoves[index].vertical,
					position.Item2 + listMoves[index].horizontal
					);
				bool trouve = pieces.TryGetValue(positionDestination, out destination);
				if(trouve)
                {
					if(piece.GetColor() == destination.GetColor())
                    {
						continue;
                    }
                }
				returnMoves.Add(new LegalMove(piece, position, positionDestination));
			}

			return returnMoves;
        }

	}
}
