namespace PresentationLayer
{
    partial class FormConta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCheckIn = new System.Windows.Forms.Panel();
            this.labelConta = new System.Windows.Forms.Label();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.panelQuartos = new System.Windows.Forms.Panel();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.labelQuartos = new System.Windows.Forms.Label();
            this.panelDados = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.linhaData = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.panelNome = new System.Windows.Forms.Panel();
            this.linhaNome = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.panelCpf = new System.Windows.Forms.Panel();
            this.linhaCpf = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.panelCep = new System.Windows.Forms.Panel();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.linhaQuarto = new System.Windows.Forms.Label();
            this.labelDados = new System.Windows.Forms.Label();
            this.panelCadastrarReserva = new System.Windows.Forms.Panel();
            this.btnReservar = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelCheckIn.SuspendLayout();
            this.panelFundo.SuspendLayout();
            this.panelQuartos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.panelDados.SuspendLayout();
            this.panelData.SuspendLayout();
            this.panelNome.SuspendLayout();
            this.panelCpf.SuspendLayout();
            this.panelCep.SuspendLayout();
            this.panelCadastrarReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelCheckIn);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 96);
            this.panelTop.TabIndex = 77;
            // 
            // panelCheckIn
            // 
            this.panelCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCheckIn.Controls.Add(this.labelConta);
            this.panelCheckIn.Location = new System.Drawing.Point(344, 22);
            this.panelCheckIn.Name = "panelCheckIn";
            this.panelCheckIn.Size = new System.Drawing.Size(101, 48);
            this.panelCheckIn.TabIndex = 0;
            // 
            // labelConta
            // 
            this.labelConta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelConta.Font = new System.Drawing.Font("GatsbyFLF", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelConta.Location = new System.Drawing.Point(0, 0);
            this.labelConta.Name = "labelConta";
            this.labelConta.Size = new System.Drawing.Size(101, 48);
            this.labelConta.TabIndex = 52;
            this.labelConta.Text = "Conta";
            // 
            // panelFundo
            // 
            this.panelFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFundo.Controls.Add(this.panelQuartos);
            this.panelFundo.Controls.Add(this.panelDados);
            this.panelFundo.Location = new System.Drawing.Point(0, 80);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(800, 286);
            this.panelFundo.TabIndex = 79;
            // 
            // panelQuartos
            // 
            this.panelQuartos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelQuartos.Controls.Add(this.dgvProdutos);
            this.panelQuartos.Controls.Add(this.labelQuartos);
            this.panelQuartos.Location = new System.Drawing.Point(2, 14);
            this.panelQuartos.Name = "panelQuartos";
            this.panelQuartos.Size = new System.Drawing.Size(251, 278);
            this.panelQuartos.TabIndex = 65;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.dgvProdutos.Location = new System.Drawing.Point(0, 54);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(251, 224);
            this.dgvProdutos.TabIndex = 78;
            // 
            // labelQuartos
            // 
            this.labelQuartos.Font = new System.Drawing.Font("GatsbyFLF", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuartos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelQuartos.Location = new System.Drawing.Point(4, 9);
            this.labelQuartos.Name = "labelQuartos";
            this.labelQuartos.Size = new System.Drawing.Size(244, 42);
            this.labelQuartos.TabIndex = 50;
            this.labelQuartos.Text = "Produtos Comprados";
            // 
            // panelDados
            // 
            this.panelDados.Controls.Add(this.panelData);
            this.panelDados.Controls.Add(this.panelNome);
            this.panelDados.Controls.Add(this.panelCpf);
            this.panelDados.Controls.Add(this.panelCep);
            this.panelDados.Controls.Add(this.labelDados);
            this.panelDados.Location = new System.Drawing.Point(256, 14);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(542, 279);
            this.panelDados.TabIndex = 66;
            // 
            // panelData
            // 
            this.panelData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelData.Controls.Add(this.linhaData);
            this.panelData.Controls.Add(this.labelData);
            this.panelData.Location = new System.Drawing.Point(19, 218);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(344, 32);
            this.panelData.TabIndex = 65;
            // 
            // linhaData
            // 
            this.linhaData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaData.Location = new System.Drawing.Point(0, 31);
            this.linhaData.Name = "linhaData";
            this.linhaData.Size = new System.Drawing.Size(344, 1);
            this.linhaData.TabIndex = 24;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelData.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.Silver;
            this.labelData.Location = new System.Drawing.Point(0, 0);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(143, 29);
            this.labelData.TabIndex = 63;
            this.labelData.Text = "Data de Entrada";
            // 
            // panelNome
            // 
            this.panelNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelNome.Controls.Add(this.linhaNome);
            this.panelNome.Controls.Add(this.labelNome);
            this.panelNome.Location = new System.Drawing.Point(19, 166);
            this.panelNome.Name = "panelNome";
            this.panelNome.Size = new System.Drawing.Size(346, 32);
            this.panelNome.TabIndex = 64;
            // 
            // linhaNome
            // 
            this.linhaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaNome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaNome.Location = new System.Drawing.Point(0, 31);
            this.linhaNome.Name = "linhaNome";
            this.linhaNome.Size = new System.Drawing.Size(346, 1);
            this.linhaNome.TabIndex = 24;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNome.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.Silver;
            this.labelNome.Location = new System.Drawing.Point(0, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(148, 29);
            this.labelNome.TabIndex = 63;
            this.labelNome.Text = "Nome do Cliente";
            // 
            // panelCpf
            // 
            this.panelCpf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCpf.Controls.Add(this.linhaCpf);
            this.panelCpf.Controls.Add(this.txtCpf);
            this.panelCpf.Location = new System.Drawing.Point(21, 115);
            this.panelCpf.Name = "panelCpf";
            this.panelCpf.Size = new System.Drawing.Size(344, 32);
            this.panelCpf.TabIndex = 61;
            // 
            // linhaCpf
            // 
            this.linhaCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaCpf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaCpf.Location = new System.Drawing.Point(0, 31);
            this.linhaCpf.Name = "linhaCpf";
            this.linhaCpf.Size = new System.Drawing.Size(344, 1);
            this.linhaCpf.TabIndex = 24;
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpf.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCpf.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.Color.Silver;
            this.txtCpf.Location = new System.Drawing.Point(0, 0);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(344, 30);
            this.txtCpf.TabIndex = 30;
            this.txtCpf.Text = "CPF do Cliente";
            // 
            // panelCep
            // 
            this.panelCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCep.Controls.Add(this.txtQuarto);
            this.panelCep.Controls.Add(this.linhaQuarto);
            this.panelCep.Location = new System.Drawing.Point(21, 65);
            this.panelCep.Name = "panelCep";
            this.panelCep.Size = new System.Drawing.Size(344, 32);
            this.panelCep.TabIndex = 57;
            // 
            // txtQuarto
            // 
            this.txtQuarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtQuarto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuarto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuarto.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuarto.ForeColor = System.Drawing.Color.Silver;
            this.txtQuarto.Location = new System.Drawing.Point(0, 0);
            this.txtQuarto.Name = "txtQuarto";
            this.txtQuarto.Size = new System.Drawing.Size(344, 30);
            this.txtQuarto.TabIndex = 31;
            this.txtQuarto.Text = "Número do Quarto";
            // 
            // linhaQuarto
            // 
            this.linhaQuarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.linhaQuarto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linhaQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaQuarto.Location = new System.Drawing.Point(0, 31);
            this.linhaQuarto.Name = "linhaQuarto";
            this.linhaQuarto.Size = new System.Drawing.Size(344, 1);
            this.linhaQuarto.TabIndex = 24;
            // 
            // labelDados
            // 
            this.labelDados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDados.Font = new System.Drawing.Font("GatsbyFLF", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelDados.Location = new System.Drawing.Point(13, 9);
            this.labelDados.Name = "labelDados";
            this.labelDados.Size = new System.Drawing.Size(117, 42);
            this.labelDados.TabIndex = 51;
            this.labelDados.Text = "Dados";
            this.labelDados.Click += new System.EventHandler(this.labelDados_Click);
            // 
            // panelCadastrarReserva
            // 
            this.panelCadastrarReserva.Controls.Add(this.btnReservar);
            this.panelCadastrarReserva.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCadastrarReserva.Location = new System.Drawing.Point(0, 366);
            this.panelCadastrarReserva.Name = "panelCadastrarReserva";
            this.panelCadastrarReserva.Size = new System.Drawing.Size(800, 84);
            this.panelCadastrarReserva.TabIndex = 78;
            // 
            // btnReservar
            // 
            this.btnReservar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnReservar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReservar.Enabled = false;
            this.btnReservar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnReservar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnReservar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Font = new System.Drawing.Font("GatsbyFLF", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnReservar.Location = new System.Drawing.Point(186, 10);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(423, 45);
            this.btnReservar.TabIndex = 20;
            this.btnReservar.Text = "CALCULAR CONTA";
            this.btnReservar.UseVisualStyleBackColor = false;
            // 
            // FormConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelFundo);
            this.Controls.Add(this.panelCadastrarReserva);
            this.Name = "FormConta";
            this.Text = "FormConta";
            this.panelTop.ResumeLayout(false);
            this.panelCheckIn.ResumeLayout(false);
            this.panelFundo.ResumeLayout(false);
            this.panelQuartos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.panelDados.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panelNome.ResumeLayout(false);
            this.panelNome.PerformLayout();
            this.panelCpf.ResumeLayout(false);
            this.panelCpf.PerformLayout();
            this.panelCep.ResumeLayout(false);
            this.panelCep.PerformLayout();
            this.panelCadastrarReserva.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCheckIn;
        private System.Windows.Forms.Label labelConta;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Panel panelQuartos;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label labelQuartos;
        private System.Windows.Forms.Panel panelDados;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label linhaData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Panel panelNome;
        private System.Windows.Forms.Label linhaNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Panel panelCpf;
        private System.Windows.Forms.Label linhaCpf;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Panel panelCep;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.Label linhaQuarto;
        private System.Windows.Forms.Label labelDados;
        private System.Windows.Forms.Panel panelCadastrarReserva;
        private System.Windows.Forms.Button btnReservar;
    }
}