using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirinto
{
    public partial class frmLabirinto : Form
    {
        Labirintos lab;
        public frmLabirinto()
        {
            InitializeComponent();
        }

        private void BtnArquivo_Click(object sender, EventArgs e)
        {
            if(dlgAbrir.ShowDialog() == DialogResult.OK)
            {
                lab = new Labirintos(dlgAbrir.FileName);
                lab.ExibirLabirinto(dgvLabirinto, dgvCaminhos);
            }
        }

        private void BtnEncontrarCaminhos_Click(object sender, EventArgs e)
        {
            lab.PilhaMovimentos(dgvLabirinto);
            lab.MostrarMovimentos(dgvCaminhos);

        }


        private void dgvCaminhos_CellClick(System.Object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgvCaminhos.Rows[index].Selected = true;

            MessageBox.Show("funciona !");
            //aqui a gente tem q fazer ele aparecer o caminho no dgv da esquerda
        }
    }
}
