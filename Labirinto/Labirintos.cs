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
    }
}
