using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
	public interface IPiece
	{
		enum Color
        {
			Black, White
        }

		Color GetColor();

		List<ProspectiveMove> Capabilities();

		bool CanSkip();

		bool CanCastle();

		/// <summary>
		/// C'est le pion!
		/// </summary>
		/// <returns>True si c'est un pion, false sinon</returns>
		bool IsPawn(); 
	}
}

