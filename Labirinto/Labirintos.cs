using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace Labirinto
{
    class Labirintos
    {
        private char[,] matriz;
        private List<PilhaLista<Movimentos>> caminhosEncontrados = new List<PilhaLista<Movimentos>>();

        public Labirintos(String nomeArquivo) //faz a leitura do arquivo texto
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

        public void ExibirLabirinto(DataGridView dgv, DataGridView dgvCaminhos) // exibe o labirinto do arquivo texto no dataGridView da esquerda
        {
            dgvCaminhos.Rows.Clear();
            for(int i = 0; i < dgv.RowCount; i++)
            {
                for(int j = 0; j < dgv.ColumnCount; j++)
                {
                    dgv.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
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
        private bool PosicaoEstaVazia(int linha, int coluna)// verifica se a proxima posição esta vazia, se pode avançar
        {
           
            char resposta = matriz[linha, coluna];

            if (resposta == ' ')
                return true;
            else
                return false;
        }

        private bool chegou(int linha, int coluna) //verifica se já chegou ao final do labirinto
        {
            char resposta = matriz[linha, coluna];

            if (resposta == 'S')
                return true;
            return false;
        }

        public void Voltar(PilhaLista<Movimentos> pilha, ref int linhaAtual, ref int colunaAtual, DataGridView  dgv) //caso nao seja possível avançar, volta para a posição anterior
        {
            Movimentos mov = pilha.OTopo();
            linhaAtual = mov.Linha;
            colunaAtual = mov.Coluna;
        }


        public void Avançar(PilhaLista<Movimentos> pilha, int proximaLinha, int proximaColuna, ref int linhaAtual, ref int colunaAtual, ref bool seMoveu, DataGridView dgv)
        // passa para a próxima posição possível e marca com um "X" as posições que ja foram passadas
        {
            seMoveu = true;
            matriz[proximaLinha, proximaColuna] = 'X';
            linhaAtual = proximaLinha;
            colunaAtual = proximaColuna;
            pilha.Empilhar(new Movimentos(linhaAtual, colunaAtual));
        }

        public void PilhaMovimentos(DataGridView dgv) //método principal da classe. Testa todos os movimentos e chama os demais métodos quando necessário.
        {
            var pilha = new PilhaLista<Movimentos>();
            pilha.Empilhar(new Movimentos(1, 1));

            int linhaAtual = 1,
                colunaAtual = 1;

            bool temCaminhoPossivel = true;

            int[] movLinhas = { -1, -1, 0, 1, 1, 1, 0, -1 };
            int[] movColunas = { 0, 1, 1, 1, 0, -1, -1, -1 };

            while(temCaminhoPossivel)
            {
                bool seMoveu = false;
                for (int i = 0; i < movLinhas.Length; i++)
                {
                    int proximaLinha = linhaAtual + movLinhas[i];
                    int proximaColuna = colunaAtual + movColunas[i]; 

                    if (PosicaoEstaVazia(proximaLinha, proximaColuna))
                        Avançar(pilha, proximaLinha, proximaColuna, ref linhaAtual, ref colunaAtual, ref seMoveu, dgv);
                    else
                        if(chegou(proximaLinha, proximaColuna))
                        {
                            pilha.Empilhar(new Movimentos(proximaLinha, proximaColuna));
                            caminhosEncontrados.Add(pilha.Clone());
                            pilha.Desempilhar();
                        }
                }

                if(seMoveu == false)
                {
                    pilha.Desempilhar();
                    if (pilha.EstaVazia)
                        temCaminhoPossivel = false;
                    else
                    {
                        Voltar(pilha, ref linhaAtual, ref colunaAtual, dgv);
                    }
                }
            }           
        }

        public void MostrarQuePassou(DataGridView dgv, int linha, int coluna, bool passou) //pinta as células do DataGridView da esquerda conforme essas são passadas
        {
            if (passou)
                dgv.Rows[linha].Cells[coluna].Style.BackColor = Color.Blue;
            else
                dgv.Rows[linha].Cells[coluna].Style.BackColor = Color.White;

            Thread.Sleep(100);
            Application.DoEvents();
        }

        public void MostrarMovimentos(DataGridView dgv) //mostra a lista de pilhas de caminhos no dataGridView da direita
        {
            ajustarDgv(dgv);
            int linhaDgv = 0;
            foreach(PilhaLista<Movimentos> caminho in caminhosEncontrados)
            {
                PilhaLista<Movimentos> caminhoClonado = caminho.Clone();
                int t = caminhoClonado.Tamanho;
                for(int i = t-1; i >= 0; i--)
                {
                    Movimentos mov = caminhoClonado.Desempilhar();
                    dgv.Rows[linhaDgv].Cells[i].Value = mov.Linha + " " + mov.Coluna;
                }
                linhaDgv++;
            }
        }

        private void ajustarDgv(DataGridView dgv) //ajusta o dgv de acordo com o tamanho da matriz do labirinto
        {
            dgv.RowCount = matriz.GetLength(0);
            dgv.ColumnCount = matriz.GetLength(1);
            dgv.ColumnHeadersVisible = false;
            dgv.RowHeadersVisible = false;
        }
    }
}
