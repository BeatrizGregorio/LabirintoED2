namespace Labirinto
{
    partial class frmLabirinto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLabirinto = new System.Windows.Forms.Label();
            this.lblCaminhos = new System.Windows.Forms.Label();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.btnEncontrarCaminhos = new System.Windows.Forms.Button();
            this.dgvLabirinto = new System.Windows.Forms.DataGridView();
            this.dgvCaminhos = new System.Windows.Forms.DataGridView();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabirinto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLabirinto
            // 
            this.lblLabirinto.AutoSize = true;
            this.lblLabirinto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblLabirinto.Location = new System.Drawing.Point(12, 36);
            this.lblLabirinto.Name = "lblLabirinto";
            this.lblLabirinto.Size = new System.Drawing.Size(64, 18);
            this.lblLabirinto.TabIndex = 0;
            this.lblLabirinto.Text = "Labirinto";
            // 
            // lblCaminhos
            // 
            this.lblCaminhos.AutoSize = true;
            this.lblCaminhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCaminhos.Location = new System.Drawing.Point(386, 36);
            this.lblCaminhos.Name = "lblCaminhos";
            this.lblCaminhos.Size = new System.Drawing.Size(163, 18);
            this.lblCaminhos.TabIndex = 1;
            this.lblCaminhos.Text = "Caminhos encontrados";
            // 
            // btnArquivo
            // 
            this.btnArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnArquivo.Location = new System.Drawing.Point(594, 12);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(95, 50);
            this.btnArquivo.TabIndex = 2;
            this.btnArquivo.Text = "Abrir arquivo";
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.BtnArquivo_Click);
            // 
            // btnEncontrarCaminhos
            // 
            this.btnEncontrarCaminhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEncontrarCaminhos.Location = new System.Drawing.Point(695, 12);
            this.btnEncontrarCaminhos.Name = "btnEncontrarCaminhos";
            this.btnEncontrarCaminhos.Size = new System.Drawing.Size(91, 50);
            this.btnEncontrarCaminhos.TabIndex = 3;
            this.btnEncontrarCaminhos.Text = "Encontrar caminhos";
            this.btnEncontrarCaminhos.UseVisualStyleBackColor = true;
            // 
            // dgvLabirinto
            // 
            this.dgvLabirinto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLabirinto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLabirinto.Location = new System.Drawing.Point(12, 68);
            this.dgvLabirinto.Name = "dgvLabirinto";
            this.dgvLabirinto.Size = new System.Drawing.Size(358, 299);
            this.dgvLabirinto.TabIndex = 4;
            // 
            // dgvCaminhos
            // 
            this.dgvCaminhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaminhos.Location = new System.Drawing.Point(389, 68);
            this.dgvCaminhos.Name = "dgvCaminhos";
            this.dgvCaminhos.Size = new System.Drawing.Size(397, 299);
            this.dgvCaminhos.TabIndex = 5;
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "openFileDialog1";
            // 
            // frmLabirinto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 380);
            this.Controls.Add(this.dgvCaminhos);
            this.Controls.Add(this.dgvLabirinto);
            this.Controls.Add(this.btnEncontrarCaminhos);
            this.Controls.Add(this.btnArquivo);
            this.Controls.Add(this.lblCaminhos);
            this.Controls.Add(this.lblLabirinto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLabirinto";
            this.Text = "Caminhos em Labirinto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabirinto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLabirinto;
        private System.Windows.Forms.Label lblCaminhos;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.Button btnEncontrarCaminhos;
        private System.Windows.Forms.DataGridView dgvLabirinto;
        private System.Windows.Forms.DataGridView dgvCaminhos;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
    }
}

