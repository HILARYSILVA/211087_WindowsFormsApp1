namespace WindowsFormsApp1.Views
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCidade = new System.Windows.Forms.ComboBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.chkVenda = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUF = new System.Windows.Forms.Label();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Location = new System.Drawing.Point(16, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 36);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = true;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.txtID.ForeColor = System.Drawing.Color.Red;
            this.txtID.Location = new System.Drawing.Point(4, 0);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(59, 29);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "txtID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(11, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(13, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label4.Location = new System.Drawing.Point(431, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data de nascimento";
            // 
            // cboCidade
            // 
            this.cboCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cboCidade.FormattingEnabled = true;
            this.cboCidade.Location = new System.Drawing.Point(16, 226);
            this.cboCidade.Name = "cboCidade";
            this.cboCidade.Size = new System.Drawing.Size(249, 28);
            this.cboCidade.TabIndex = 8;
            this.cboCidade.SelectedIndexChanged += new System.EventHandler(this.cboCidade_SelectedIndexChanged_1);
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.mskCPF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mskCPF.Location = new System.Drawing.Point(18, 296);
            this.mskCPF.Mask = "999.999.999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(247, 26);
            this.mskCPF.TabIndex = 9;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(436, 316);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(116, 26);
            this.dtpDataNasc.TabIndex = 10;
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIncluir.Font = new System.Drawing.Font("MS UI Gothic", 17.25F);
            this.BtnIncluir.Location = new System.Drawing.Point(75, 360);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(155, 44);
            this.BtnIncluir.TabIndex = 11;
            this.BtnIncluir.Text = "INCLUIR";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click_1);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterar.Font = new System.Drawing.Font("MS UI Gothic", 17.25F);
            this.BtnAlterar.Location = new System.Drawing.Point(236, 360);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(155, 44);
            this.BtnAlterar.TabIndex = 12;
            this.BtnAlterar.Text = "ALTERAR";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click_1);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("MS UI Gothic", 17.25F);
            this.BtnCancelar.Location = new System.Drawing.Point(397, 360);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(155, 44);
            this.BtnCancelar.TabIndex = 13;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.Font = new System.Drawing.Font("MS UI Gothic", 17.25F);
            this.BtnExcluir.Location = new System.Drawing.Point(560, 360);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(155, 44);
            this.BtnExcluir.TabIndex = 14;
            this.BtnExcluir.Text = "EXCLUIR";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Font = new System.Drawing.Font("Yu Gothic UI", 24.25F);
            this.BtnFechar.Location = new System.Drawing.Point(698, 12);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 51);
            this.BtnFechar.TabIndex = 15;
            this.BtnFechar.Text = "x";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label5.Location = new System.Drawing.Point(22, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(391, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Digite o nome do cliente para pesquisa:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtPesquisa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPesquisa.Location = new System.Drawing.Point(26, 463);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(480, 26);
            this.txtPesquisa.TabIndex = 17;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.BtnConsultar.Location = new System.Drawing.Point(623, 618);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(133, 44);
            this.BtnConsultar.TabIndex = 18;
            this.BtnConsultar.Text = "CONSULTAR";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(26, 512);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(573, 150);
            this.dgvClientes.TabIndex = 19;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // chkVenda
            // 
            this.chkVenda.AutoSize = true;
            this.chkVenda.BackColor = System.Drawing.SystemColors.Control;
            this.chkVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.chkVenda.Location = new System.Drawing.Point(165, 60);
            this.chkVenda.Name = "chkVenda";
            this.chkVenda.Size = new System.Drawing.Size(157, 24);
            this.chkVenda.TabIndex = 20;
            this.chkVenda.Text = "Bloqueiar venda?";
            this.chkVenda.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtUF);
            this.panel3.Location = new System.Drawing.Point(273, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(118, 28);
            this.panel3.TabIndex = 22;
            // 
            // txtUF
            // 
            this.txtUF.AutoSize = true;
            this.txtUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtUF.Location = new System.Drawing.Point(27, 1);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(63, 25);
            this.txtUF.TabIndex = 23;
            this.txtUF.Text = "txtUF";
            // 
            // txtRenda
            // 
            this.txtRenda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtRenda.Location = new System.Drawing.Point(436, 247);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(212, 26);
            this.txtRenda.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label7.Location = new System.Drawing.Point(431, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Renda";
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(510, 25);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(167, 149);
            this.picFoto.TabIndex = 25;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label8.Location = new System.Drawing.Point(13, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNome.Location = new System.Drawing.Point(18, 137);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(358, 26);
            this.txtNome.TabIndex = 28;
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "openFileDialog1";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 684);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRenda);
            this.Controls.Add(this.chkVenda);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.cboCidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboCidade;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.CheckBox chkVenda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txtUF;
        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
    }
}