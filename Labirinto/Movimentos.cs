
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirinto
{
    class Movimentos : IComparable<Movimentos>
    {
        private int linha, coluna;
        public Movimentos(int li, int col)
        {
            linha = li;
            coluna = col;
        }

        public int Linha
        {
            get => linha;
            set => linha = value; 
        }

        public int Coluna
        {
            get => coluna;
            set => coluna = value;
        }
        public override String ToString()
        {
            return linha + " " + coluna;
        }

        public int CompareTo(Movimentos outro) //método compatível com ListaSimples e NoLista
        {
            return 0;
        }
    }
}
