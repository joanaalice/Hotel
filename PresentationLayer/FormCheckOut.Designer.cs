namespace PresentationLayer
{
    partial class FormCheckOut
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
            this.labelCheckIn = new System.Windows.Forms.Label();
            this.panelDados = new System.Windows.Forms.Panel();
            this.panelNome = new System.Windows.Forms.Panel();
            this.linhaNome = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.panelCpf = new System.Windows.Forms.Panel();
            this.linhaCpf = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.panelCep = new System.Windows.Forms.Panel();
            this.linhaQuarto = new System.Windows.Forms.Label();
            this.labelDados = new System.Windows.Forms.Label();
            this.panelCadastrarReserva = new System.Windows.Forms.Panel();
            this.btnReservar = new System.Windows.Forms.Button();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.labelQuartos = new System.Windows.Forms.Label();
            this.dgvQuartos = new System.Windows.Forms.DataGridView();
            this.btnTipoDeQuarto = new System.Windows.Forms.Button();
            this.panelTipoDeQuarto = new System.Windows.Forms.Panel();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnSolteiro = new System.Windows.Forms.Button();
            this.btnDuplo = new System.Windows.Forms.Button();
            this.btnCasal = new System.Windows.Forms.Button();
            this.btnDormitorio = new System.Windows.Forms.Button();
            this.panelQuartos = new System.Windows.Forms.Panel();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.linkLabelSaidaAntecipada = new System.Windows.Forms.LinkLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.linhaData = new System.Windows.Forms.Label();
            this.panelData = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelCheckIn.SuspendLayout();
            this.panelDados.SuspendLayout();
            this.panelNome.SuspendLayout();
            this.panelCpf.SuspendLayout();
            this.panelCep.SuspendLayout();
            this.panelCadastrarReserva.SuspendLayout();
            this.panelFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).BeginInit();
            this.panelTipoDeQuarto.SuspendLayout();
            this.panelQuartos.SuspendLayout();
            this.panelData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelCheckIn);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 96);
            this.panelTop.TabIndex = 74;
            // 
            // panelCheckIn
            // 
            this.panelCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCheckIn.Controls.Add(this.labelCheckIn);
            this.panelCheckIn.Location = new System.Drawing.Point(307, 22);
            this.panelCheckIn.Name = "panelCheckIn";
            this.panelCheckIn.Size = new System.Drawing.Size(177, 48);
            this.panelCheckIn.TabIndex = 0;
            // 
            // labelCheckIn
            // 
            this.labelCheckIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCheckIn.Font = new System.Drawing.Font("GatsbyFLF", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelCheckIn.Location = new System.Drawing.Point(0, 0);
            this.labelCheckIn.Name = "labelCheckIn";
            this.labelCheckIn.Size = new System.Drawing.Size(177, 48);
            this.labelCheckIn.TabIndex = 52;
            this.labelCheckIn.Text = "Check Out";
            // 
            // panelDados
            // 
            this.panelDados.Controls.Add(this.panelData);
            this.panelDados.Controls.Add(this.panelNome);
            this.panelDados.Controls.Add(this.panelCpf);
            this.panelDados.Controls.Add(this.panelCep);
            this.panelDados.Controls.Add(this.labelDados);
            this.panelDados.Location = new System.Drawing.Point(394, 14);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(404, 279);
            this.panelDados.TabIndex = 66;
            // 
            // panelNome
            // 
            this.panelNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelNome.Controls.Add(this.linhaNome);
            this.panelNome.Controls.Add(this.labelNome);
            this.panelNome.Location = new System.Drawing.Point(32, 157);
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
            this.panelCpf.Location = new System.Drawing.Point(34, 106);
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
            this.panelCep.Location = new System.Drawing.Point(34, 56);
            this.panelCep.Name = "panelCep";
            this.panelCep.Size = new System.Drawing.Size(344, 32);
            this.panelCep.TabIndex = 57;
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
            this.labelDados.Location = new System.Drawing.Point(26, 9);
            this.labelDados.Name = "labelDados";
            this.labelDados.Size = new System.Drawing.Size(117, 42);
            this.labelDados.TabIndex = 51;
            this.labelDados.Text = "Dados";
            // 
            // panelCadastrarReserva
            // 
            this.panelCadastrarReserva.Controls.Add(this.btnReservar);
            this.panelCadastrarReserva.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCadastrarReserva.Location = new System.Drawing.Point(0, 366);
            this.panelCadastrarReserva.Name = "panelCadastrarReserva";
            this.panelCadastrarReserva.Size = new System.Drawing.Size(800, 84);
            this.panelCadastrarReserva.TabIndex = 75;
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
            this.panelFundo.TabIndex = 76;
            // 
            // labelQuartos
            // 
            this.labelQuartos.Font = new System.Drawing.Font("GatsbyFLF", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuartos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelQuartos.Location = new System.Drawing.Point(4, 9);
            this.labelQuartos.Name = "labelQuartos";
            this.labelQuartos.Size = new System.Drawing.Size(385, 42);
            this.labelQuartos.TabIndex = 50;
            this.labelQuartos.Text = "Quartos com saída prevista para hoje";
            // 
            // dgvQuartos
            // 
            this.dgvQuartos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvQuartos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuartos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuartos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQuartos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvQuartos.EnableHeadersVisualStyles = false;
            this.dgvQuartos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.dgvQuartos.Location = new System.Drawing.Point(0, 86);
            this.dgvQuartos.Name = "dgvQuartos";
            this.dgvQuartos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQuartos.RowHeadersVisible = false;
            this.dgvQuartos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvQuartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuartos.Size = new System.Drawing.Size(393, 192);
            this.dgvQuartos.TabIndex = 78;
            // 
            // btnTipoDeQuarto
            // 
            this.btnTipoDeQuarto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTipoDeQuarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnTipoDeQuarto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTipoDeQuarto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnTipoDeQuarto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnTipoDeQuarto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTipoDeQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoDeQuarto.Font = new System.Drawing.Font("GatsbyFLF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoDeQuarto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnTipoDeQuarto.Location = new System.Drawing.Point(250, 51);
            this.btnTipoDeQuarto.Name = "btnTipoDeQuarto";
            this.btnTipoDeQuarto.Size = new System.Drawing.Size(119, 30);
            this.btnTipoDeQuarto.TabIndex = 79;
            this.btnTipoDeQuarto.Text = "Tipo de quarto";
            this.btnTipoDeQuarto.UseVisualStyleBackColor = false;
            // 
            // panelTipoDeQuarto
            // 
            this.panelTipoDeQuarto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTipoDeQuarto.Controls.Add(this.btnDormitorio);
            this.panelTipoDeQuarto.Controls.Add(this.btnCasal);
            this.panelTipoDeQuarto.Controls.Add(this.btnDuplo);
            this.panelTipoDeQuarto.Controls.Add(this.btnSolteiro);
            this.panelTipoDeQuarto.Controls.Add(this.btnTodos);
            this.panelTipoDeQuarto.Location = new System.Drawing.Point(250, 86);
            this.panelTipoDeQuarto.Name = "panelTipoDeQuarto";
            this.panelTipoDeQuarto.Size = new System.Drawing.Size(119, 152);
            this.panelTipoDeQuarto.TabIndex = 1;
            this.panelTipoDeQuarto.Visible = false;
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnTodos.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTodos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTodos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("GatsbyFLF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnTodos.Location = new System.Drawing.Point(0, 0);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(119, 30);
            this.btnTodos.TabIndex = 80;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = false;
            // 
            // btnSolteiro
            // 
            this.btnSolteiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnSolteiro.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSolteiro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSolteiro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnSolteiro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnSolteiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSolteiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolteiro.Font = new System.Drawing.Font("GatsbyFLF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolteiro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnSolteiro.Location = new System.Drawing.Point(0, 30);
            this.btnSolteiro.Name = "btnSolteiro";
            this.btnSolteiro.Size = new System.Drawing.Size(119, 30);
            this.btnSolteiro.TabIndex = 81;
            this.btnSolteiro.Text = "Solteiro";
            this.btnSolteiro.UseVisualStyleBackColor = false;
            // 
            // btnDuplo
            // 
            this.btnDuplo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnDuplo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDuplo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDuplo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnDuplo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnDuplo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDuplo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuplo.Font = new System.Drawing.Font("GatsbyFLF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuplo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnDuplo.Location = new System.Drawing.Point(0, 60);
            this.btnDuplo.Name = "btnDuplo";
            this.btnDuplo.Size = new System.Drawing.Size(119, 30);
            this.btnDuplo.TabIndex = 82;
            this.btnDuplo.Text = "Duplo";
            this.btnDuplo.UseVisualStyleBackColor = false;
            // 
            // btnCasal
            // 
            this.btnCasal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCasal.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCasal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCasal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnCasal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnCasal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCasal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCasal.Font = new System.Drawing.Font("GatsbyFLF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnCasal.Location = new System.Drawing.Point(0, 90);
            this.btnCasal.Name = "btnCasal";
            this.btnCasal.Size = new System.Drawing.Size(119, 30);
            this.btnCasal.TabIndex = 83;
            this.btnCasal.Text = "Casal";
            this.btnCasal.UseVisualStyleBackColor = false;
            // 
            // btnDormitorio
            // 
            this.btnDormitorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnDormitorio.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDormitorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDormitorio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnDormitorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnDormitorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDormitorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDormitorio.Font = new System.Drawing.Font("GatsbyFLF", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDormitorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.btnDormitorio.Location = new System.Drawing.Point(0, 120);
            this.btnDormitorio.Name = "btnDormitorio";
            this.btnDormitorio.Size = new System.Drawing.Size(119, 30);
            this.btnDormitorio.TabIndex = 84;
            this.btnDormitorio.Text = "Dormitorio";
            this.btnDormitorio.UseVisualStyleBackColor = false;
            // 
            // panelQuartos
            // 
            this.panelQuartos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelQuartos.Controls.Add(this.linkLabelSaidaAntecipada);
            this.panelQuartos.Controls.Add(this.dateTimePicker1);
            this.panelQuartos.Controls.Add(this.panelTipoDeQuarto);
            this.panelQuartos.Controls.Add(this.btnTipoDeQuarto);
            this.panelQuartos.Controls.Add(this.dgvQuartos);
            this.panelQuartos.Controls.Add(this.labelQuartos);
            this.panelQuartos.Location = new System.Drawing.Point(2, 14);
            this.panelQuartos.Name = "panelQuartos";
            this.panelQuartos.Size = new System.Drawing.Size(393, 278);
            this.panelQuartos.TabIndex = 65;
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
            // linkLabelSaidaAntecipada
            // 
            this.linkLabelSaidaAntecipada.ActiveLinkColor = System.Drawing.Color.Silver;
            this.linkLabelSaidaAntecipada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelSaidaAntecipada.AutoSize = true;
            this.linkLabelSaidaAntecipada.Font = new System.Drawing.Font("GatsbyFLF", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSaidaAntecipada.LinkColor = System.Drawing.Color.Silver;
            this.linkLabelSaidaAntecipada.Location = new System.Drawing.Point(10, 56);
            this.linkLabelSaidaAntecipada.Name = "linkLabelSaidaAntecipada";
            this.linkLabelSaidaAntecipada.Size = new System.Drawing.Size(110, 20);
            this.linkLabelSaidaAntecipada.TabIndex = 79;
            this.linkLabelSaidaAntecipada.TabStop = true;
            this.linkLabelSaidaAntecipada.Text = "Saída antecipada?";
            this.linkLabelSaidaAntecipada.VisitedLinkColor = System.Drawing.Color.Silver;
            this.linkLabelSaidaAntecipada.Click += new System.EventHandler(this.linkLabelSaidaAntecipada_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker1.TabIndex = 66;
            this.dateTimePicker1.Visible = false;
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
            // panelData
            // 
            this.panelData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelData.Controls.Add(this.linhaData);
            this.panelData.Controls.Add(this.labelData);
            this.panelData.Location = new System.Drawing.Point(32, 209);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(344, 32);
            this.panelData.TabIndex = 65;
            // 
            // FormCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelFundo);
            this.Controls.Add(this.panelCadastrarReserva);
            this.Name = "FormCheckOut";
            this.Text = "FormCheckOut";
            this.panelTop.ResumeLayout(false);
            this.panelCheckIn.ResumeLayout(false);
            this.panelDados.ResumeLayout(false);
            this.panelNome.ResumeLayout(false);
            this.panelNome.PerformLayout();
            this.panelCpf.ResumeLayout(false);
            this.panelCpf.PerformLayout();
            this.panelCep.ResumeLayout(false);
            this.panelCep.PerformLayout();
            this.panelCadastrarReserva.ResumeLayout(false);
            this.panelFundo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).EndInit();
            this.panelTipoDeQuarto.ResumeLayout(false);
            this.panelQuartos.ResumeLayout(false);
            this.panelQuartos.PerformLayout();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCheckIn;
        private System.Windows.Forms.Label labelCheckIn;
        private System.Windows.Forms.Panel panelDados;
        private System.Windows.Forms.Panel panelNome;
        private System.Windows.Forms.Label linhaNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Panel panelCpf;
        private System.Windows.Forms.Label linhaCpf;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Panel panelCep;
        private System.Windows.Forms.Label linhaQuarto;
        private System.Windows.Forms.Label labelDados;
        private System.Windows.Forms.Panel panelCadastrarReserva;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Panel panelQuartos;
        private System.Windows.Forms.Panel panelTipoDeQuarto;
        private System.Windows.Forms.Button btnDormitorio;
        private System.Windows.Forms.Button btnCasal;
        private System.Windows.Forms.Button btnDuplo;
        private System.Windows.Forms.Button btnSolteiro;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.LinkLabel linkLabelSaidaAntecipada;
        private System.Windows.Forms.Button btnTipoDeQuarto;
        private System.Windows.Forms.DataGridView dgvQuartos;
        private System.Windows.Forms.Label labelQuartos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label linhaData;
        private System.Windows.Forms.Label labelData;
    }
}