using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_421
{
	public class Jeu
	{
		int nbManches = 5;
		readonly int nbDes = 6;
		readonly int nbDesTruques;
		public De[] Des = new De[0];
		public DeTruque[] DesTruques = new DeTruque[0];
		public Jeu(int nbManches, int nbDes, int nbDesTruques)
		{
			this.nbManches = nbManches;
			this.nbDes = nbDes;
			this.nbDesTruques = nbDesTruques;

			this.Des = new De[nbDes];
			this.DesTruques = new DeTruque[nbDesTruques];

			for (int i = 0; i < nbDes; i++)
            {
				this.Des[i] = new De(6);
            }
			for (int i = 0; i < nbDesTruques; i++)
			{
				this.DesTruques[i] = new DeTruque(6);
			}
			Des = Des.Concat(DesTruques).ToArray();
		}

		public override string ToString()
		{ 
			string toString = "";
            for (int i = 0; i < Des.Count(); i++)
            {
				toString += "+---+ ";
			}
			toString += "\n";
			foreach (De D in Des)
			{
				toString += "| " + D.ToString() + " | ";
			}
			toString += "\n";
			for (int i = 0; i < Des.Count(); i++)
			{
				toString += "+---+ ";
			}
			return toString;
		}

        public int Relancer(int i)
        {
			if (i > Des.Count() || i < 1)
            {
				return 0;
            }
			int nFace = Des[i-1].Lancer();
			return nFace;
        }

        public int Score()
        {
			int score = 0;
			foreach (De D in Des)
			{
				score += D.Face;
			}
			return score;
		}

        public void Run()
        {
            while (nbManches > 0)
            {
				Console.WriteLine(ToString());
				Console.WriteLine("Quels sont les dés que vous voulez relancer ?");
				string choix = Console.ReadLine();
				string[] dChoix = choix.Split(' ');

				foreach (string c in dChoix)
				{
					Relancer(int.Parse(c));
				}
				int score = Score();
				Console.WriteLine("Score actuel : " + score);
				nbManches--;
			}
			Console.WriteLine(ToString());
		}
    }
}
