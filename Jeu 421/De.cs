using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_421
{
	public class De
	{
		private int nbFaces;
		private int face = 1;
		Random random = new Random();

		public De(int anbFaces)
        {
            this.nbFaces = anbFaces;
			face = Lancer();
		}

		public int NbFaces
		{
			get { return nbFaces; }
			set { nbFaces = value; }
		}

		public int Face
		{
			get { return face; }
		}

		public int Lancer()
		{
			face = random.Next(1, nbFaces + 1);
			return face;
		}
        public override string ToString()
        {
			string toString = face + "";
            return toString;
        }
    }
}