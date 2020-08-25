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
                lab.ExibirLabirinto(dgvLabirinto);
            }
        }
    }
}
