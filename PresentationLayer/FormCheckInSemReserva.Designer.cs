namespace PresentationLayer
{
    partial class FormCheckInSemReserva
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCheckIn = new System.Windows.Forms.Panel();
            this.labelCheckIn = new System.Windows.Forms.Label();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.panelQuartos = new System.Windows.Forms.Panel();
            this.panelTipoDeQuarto = new System.Windows.Forms.Panel();
            this.btnDormitorio = new System.Windows.Forms.Button();
            this.btnCasal = new System.Windows.Forms.Button();
            this.btnDuplo = new System.Windows.Forms.Button();
            this.btnSolteiro = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.labelSaida = new System.Windows.Forms.Label();
            this.dtpSaida = new System.Windows.Forms.DateTimePicker();
            this.btnTipoDeQuarto = new System.Windows.Forms.Button();
            this.dgvQuartos = new System.Windows.Forms.DataGridView();
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
            this.labelQuarto = new System.Windows.Forms.Label();
            this.linhaQuarto = new System.Windows.Forms.Label();
            this.labelDados = new System.Windows.Forms.Label();
            this.panelCadastrarReserva = new System.Windows.Forms.Panel();
            this.btnReservar = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelCheckIn.SuspendLayout();
            this.panelFundo.SuspendLayout();
            this.panelQuartos.SuspendLayout();
            this.panelTipoDeQuarto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).BeginInit();
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
            this.panelTop.TabIndex = 71;
            // 
            // panelCheckIn
            // 
            this.panelCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCheckIn.Controls.Add(this.labelCheckIn);
            this.panelCheckIn.Location = new System.Drawing.Point(323, 22);
            this.panelCheckIn.Name = "panelCheckIn";
            this.panelCheckIn.Size = new System.Drawing.Size(141, 48);
            this.panelCheckIn.TabIndex = 0;
            // 
            // labelCheckIn
            // 
            this.labelCheckIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCheckIn.Font = new System.Drawing.Font("GatsbyFLF", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelCheckIn.Location = new System.Drawing.Point(0, 0);
            this.labelCheckIn.Name = "labelCheckIn";
            this.labelCheckIn.Size = new System.Drawing.Size(141, 48);
            this.labelCheckIn.TabIndex = 52;
            this.labelCheckIn.Text = "Check In";
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
            this.panelFundo.TabIndex = 73;
            // 
            // panelQuartos
            // 
            this.panelQuartos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelQuartos.Controls.Add(this.panelTipoDeQuarto);
            this.panelQuartos.Controls.Add(this.labelSaida);
            this.panelQuartos.Controls.Add(this.dtpSaida);
            this.panelQuartos.Controls.Add(this.btnTipoDeQuarto);
            this.panelQuartos.Controls.Add(this.dgvQuartos);
            this.panelQuartos.Controls.Add(this.labelQuartos);
            this.panelQuartos.Location = new System.Drawing.Point(2, -1);
            this.panelQuartos.Name = "panelQuartos";
            this.panelQuartos.Size = new System.Drawing.Size(393, 293);
            this.panelQuartos.TabIndex = 65;
            // 
            // panelTipoDeQuarto
            // 
            this.panelTipoDeQuarto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTipoDeQuarto.Controls.Add(this.btnDormitorio);
            this.panelTipoDeQuarto.Controls.Add(this.btnCasal);
            this.panelTipoDeQuarto.Controls.Add(this.btnDuplo);
            this.panelTipoDeQuarto.Controls.Add(this.btnSolteiro);
            this.panelTipoDeQuarto.Controls.Add(this.btnTodos);
            this.panelTipoDeQuarto.Location = new System.Drawing.Point(258, 58);
            this.panelTipoDeQuarto.Name = "panelTipoDeQuarto";
            this.panelTipoDeQuarto.Size = new System.Drawing.Size(119, 152);
            this.panelTipoDeQuarto.TabIndex = 1;
            this.panelTipoDeQuarto.Visible = false;
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
            // labelSaida
            // 
            this.labelSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSaida.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelSaida.Location = new System.Drawing.Point(36, 64);
            this.labelSaida.Name = "labelSaida";
            this.labelSaida.Size = new System.Drawing.Size(80, 27);
            this.labelSaida.TabIndex = 83;
            this.labelSaida.Text = "Saida";
            // 
            // dtpSaida
            // 
            this.dtpSaida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpSaida.CalendarForeColor = System.Drawing.Color.Silver;
            this.dtpSaida.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtpSaida.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dtpSaida.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.dtpSaida.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.dtpSaida.Location = new System.Drawing.Point(41, 94);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(179, 20);
            this.dtpSaida.TabIndex = 81;
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
            this.btnTipoDeQuarto.Location = new System.Drawing.Point(258, 23);
            this.btnTipoDeQuarto.Name = "btnTipoDeQuarto";
            this.btnTipoDeQuarto.Size = new System.Drawing.Size(119, 30);
            this.btnTipoDeQuarto.TabIndex = 79;
            this.btnTipoDeQuarto.Text = "Tipo de quarto";
            this.btnTipoDeQuarto.UseVisualStyleBackColor = false;
            // 
            // dgvQuartos
            // 
            this.dgvQuartos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgvQuartos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuartos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuartos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuartos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvQuartos.EnableHeadersVisualStyles = false;
            this.dgvQuartos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.dgvQuartos.Location = new System.Drawing.Point(0, 120);
            this.dgvQuartos.Name = "dgvQuartos";
            this.dgvQuartos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQuartos.RowHeadersVisible = false;
            this.dgvQuartos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvQuartos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuartos.Size = new System.Drawing.Size(393, 173);
            this.dgvQuartos.TabIndex = 78;
            // 
            // labelQuartos
            // 
            this.labelQuartos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQuartos.Font = new System.Drawing.Font("GatsbyFLF", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuartos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(83)))));
            this.labelQuartos.Location = new System.Drawing.Point(33, 23);
            this.labelQuartos.Name = "labelQuartos";
            this.labelQuartos.Size = new System.Drawing.Size(246, 42);
            this.labelQuartos.TabIndex = 50;
            this.labelQuartos.Text = "Quartos disponíveis";
            // 
            // panelDados
            // 
            this.panelDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelDados.Controls.Add(this.panelData);
            this.panelDados.Controls.Add(this.panelNome);
            this.panelDados.Controls.Add(this.panelCpf);
            this.panelDados.Controls.Add(this.panelCep);
            this.panelDados.Controls.Add(this.labelDados);
            this.panelDados.Location = new System.Drawing.Point(394, 0);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(404, 293);
            this.panelDados.TabIndex = 66;
            // 
            // panelData
            // 
            this.panelData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelData.Controls.Add(this.linhaData);
            this.panelData.Controls.Add(this.labelData);
            this.panelData.Location = new System.Drawing.Point(32, 229);
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
            this.labelData.Size = new System.Drawing.Size(48, 29);
            this.labelData.TabIndex = 63;
            this.labelData.Text = "Data";
            // 
            // panelNome
            // 
            this.panelNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelNome.Controls.Add(this.linhaNome);
            this.panelNome.Controls.Add(this.labelNome);
            this.panelNome.Location = new System.Drawing.Point(32, 177);
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
            this.panelCpf.Location = new System.Drawing.Point(34, 126);
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
            this.panelCep.Controls.Add(this.labelQuarto);
            this.panelCep.Controls.Add(this.linhaQuarto);
            this.panelCep.Location = new System.Drawing.Point(34, 76);
            this.panelCep.Name = "panelCep";
            this.panelCep.Size = new System.Drawing.Size(344, 32);
            this.panelCep.TabIndex = 57;
            // 
            // labelQuarto
            // 
            this.labelQuarto.AutoSize = true;
            this.labelQuarto.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQuarto.Font = new System.Drawing.Font("GatsbyFLF", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuarto.ForeColor = System.Drawing.Color.Silver;
            this.labelQuarto.Location = new System.Drawing.Point(0, 0);
            this.labelQuarto.Name = "labelQuarto";
            this.labelQuarto.Size = new System.Drawing.Size(72, 29);
            this.labelQuarto.TabIndex = 64;
            this.labelQuarto.Text = "Quarto";
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
            this.labelDados.Location = new System.Drawing.Point(26, 22);
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
            this.panelCadastrarReserva.TabIndex = 72;
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
            this.btnReservar.Text = "RESERVAR";
            this.btnReservar.UseVisualStyleBackColor = false;
            // 
            // FormCheckInSemReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelFundo);
            this.Controls.Add(this.panelCadastrarReserva);
            this.Name = "FormCheckInSemReserva";
            this.Text = "FormCheckInSemReserva";
            this.panelTop.ResumeLayout(false);
            this.panelCheckIn.ResumeLayout(false);
            this.panelFundo.ResumeLayout(false);
            this.panelQuartos.ResumeLayout(false);
            this.panelTipoDeQuarto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuartos)).EndInit();
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
        private System.Windows.Forms.Label labelCheckIn;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Panel panelQuartos;
        private System.Windows.Forms.Panel panelTipoDeQuarto;
        private System.Windows.Forms.Button btnDormitorio;
        private System.Windows.Forms.Button btnCasal;
        private System.Windows.Forms.Button btnDuplo;
        private System.Windows.Forms.Button btnSolteiro;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Label labelSaida;
        private System.Windows.Forms.DateTimePicker dtpSaida;
        private System.Windows.Forms.Button btnTipoDeQuarto;
        private System.Windows.Forms.DataGridView dgvQuartos;
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
        private System.Windows.Forms.Label labelQuarto;
        private System.Windows.Forms.Label linhaQuarto;
        private System.Windows.Forms.Label labelDados;
        private System.Windows.Forms.Panel panelCadastrarReserva;
        private System.Windows.Forms.Button btnReservar;
    }
}