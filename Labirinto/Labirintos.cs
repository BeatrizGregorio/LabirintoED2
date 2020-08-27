using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirinto
{
    class Labirintos
    {
        private char[,] matriz;
        public Labirintos(String nomeArquivo)
        {
            StreamReader sr = new StreamReader(nomeArquivo);
            int coluna = int.Parse(sr.ReadLine());
            int linha = int.Parse(sr.ReadLine());
            matriz = new char[linha, coluna];
            for(int i = 0; i < linha; i++)
            {
                string linhaArq = sr.ReadLine();
                for(int j = 0; j < coluna; j++)
                {
                    matriz[i, j] = linhaArq[j];
                }
            }
        }

        public void ExibirLabirinto(DataGridView dgv)
        {
            dgv.RowCount = matriz.GetLength(0);
            dgv.ColumnCount = matriz.GetLength(1);
            dgv.ColumnHeadersVisible = false;
            dgv.RowHeadersVisible = false;
            for(int i = 0; i<matriz.GetLength(0); i++)
            {
                for(int j = 0; j<matriz.GetLength(1); j++)
                {
                    dgv.Rows[i].Cells[j].Value = matriz[i, j];
                }
            }
        }

        public PilhaLista<Movimentos> AcharCaminho()
        {
            //determinar quais são os movimentos
          //  int[] movimentosLinhas() = { }
        }

        public void Avançar()//bia
        {
            //avançar os movimentos 
            //bia pensando bem, acho q é mais dificil fazer assim do que tudo junto
            //(nesse e no voltar)
            //tenta só fazer a logica dos dois 
        }

        public void Voltar()//bia
        {
          //fazer o backtracking, desempilhar as coisas e tal
        }

        public void mostrarQuePassou()//bia
        {
            //esse aqui é pra pintar os coisinhos do dgv
            //pinta os lugares que ja passou
        }

        public void mostrarMovimentos(DataGridView dgv) //esse eu termino depois
        {
            //isso é pra mostrar no dgv da direita os caminhos que passou
        }
    }
}
