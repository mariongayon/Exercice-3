using System;

namespace Execice3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Chess.Board board = new Chess.Board();
			var rook = new Chess.Rook(Chess.IPiece.Color.Black);
			var rookOther = new Chess.Rook(Chess.IPiece.Color.Black);
			board.pieces.Add(new Tuple<int, int>(0, 0), rook);
			board.pieces.Add(new Tuple<int, int>(0, 1), rookOther);
			var legalMoves = board.LegalMovesFrom(new Tuple<int, int>(0, 0));
		}
	}
}
