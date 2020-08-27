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
        private bool PosicaoEstaVazia(int linha, int coluna)//bia
        {
            //eu acho que isso funciona como metodo pra verificar se a posicao ta livre ou nao
            char resposta = matriz[linha, coluna];

            if (resposta == ' ')
                return true;
            else
                return false;
        }

        private bool podeAvançar(int linha, int coluna)
        {
            if (PosicaoEstaVazia(linha, coluna))
                return true;
            return false;
        }

        private bool chegou(int linha, int coluna) //verifica se ja terminou o labirinto
        {
            char resposta = matriz[linha, coluna];

            if (resposta == 'S')
                return true;
            return false;
        }

        public void Voltar()//bia
        {
          //fazer o backtracking, desempilhar as coisas e tal
        }

        public PilhaLista<Movimentos> pilhaCaminho(int linha, int coluna)
        {
            var pilha = new PilhaLista<Movimentos>();
            Movimentos mov = new Movimentos(linha, coluna);

           
            char posicaoAtual = matriz[linha, coluna];
            char inicio = matriz[1, 1];


            return pilha;
        }

        private void TestarMovimentos(int linha, int coluna)
        {
            int[] movLinhas = { -1, -1, 0, 1, 1, 1, 0, -1 };
            int[] movColunas = { 0, 1, 1, 1, 0, -1, -1, -1 };

            for(int i = 0; i<movLinhas.Length; i++)
            {
                if(PosicaoEstaVazia(linha, coluna))
                {
                    
                }
            }
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
