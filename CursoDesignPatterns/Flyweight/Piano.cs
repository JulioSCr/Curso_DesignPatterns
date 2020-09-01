using System;
using System.Collections.Generic;

namespace Flyweight
{
	public class Piano
	{
		public void Toca(IList<INota> pMusica)
		{
			foreach (INota lNota in pMusica)
			{
				Console.Beep(lNota.Frequencia, 250);
			}
		}
	}
}
