using System;

namespace Jeu_421
{
	public class DeTruque : De
	{
		private int nbFaces;
		private int face;
		public DeTruque(int anbFaces) : base(anbFaces)
		{
			this.NbFaces = anbFaces;
			face = Lancer();
		}
		public new int Lancer()
		{
			Random random = new Random();
			int chance = random.Next(1, 13);
			if (chance <= 6) {face = 6; }
			if (chance > 6 && chance <= 8){face = 5;}
			if (chance > 8 && chance <= 9){face = 4;}
			if (chance > 9 && chance <= 10){face = 3;}
			if (chance > 10 && chance <= 11){face = 2;}
			if (chance > 11 && chance <= 12){face = 1;}
			return face;
		}
	}
}