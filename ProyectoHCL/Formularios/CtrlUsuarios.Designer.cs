﻿namespace ProyectoHCL.Formularios
{
    partial class CtrlUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlUsuarios));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            btnNuevo = new Button();
            label11 = new Label();
            button2 = new Button();
            button5 = new Button();
            btnPerfil = new Button();
            btnCerrarSesion = new Button();
            panel5 = new Panel();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            cmbMostrar = new ComboBox();
            txtBuscar = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label6 = new Label();
            label7 = new Label();
            txtPaginacion = new TextBox();
            cmbPaginacion = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            txtPag = new TextBox();
            cmbPag = new ComboBox();
            panel4 = new Panel();
            dgvUsuarios = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(60, 561);
            panel1.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(5, 20);
            button1.Name = "button1";
            button1.Size = new Size(49, 36);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btnNuevo);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(btnPerfil);
            panel2.Controls.Add(btnCerrarSesion);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(60, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1024, 125);
            panel2.TabIndex = 33;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNuevo.BackColor = Color.RoyalBlue;
            btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.ForeColor = SystemColors.ButtonFace;
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(29, 68);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 39);
            btnNuevo.TabIndex = 40;
            btnNuevo.Text = "Agregar";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(19, 17);
            label11.Name = "label11";
            label11.Size = new Size(235, 32);
            label11.TabIndex = 41;
            label11.Text = "Usuarios registrados";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(2029, 74);
            button2.Name = "button2";
            button2.Size = new Size(30, 29);
            button2.TabIndex = 38;
            button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(2076, 72);
            button5.Name = "button5";
            button5.Size = new Size(35, 33);
            button5.TabIndex = 39;
            button5.UseVisualStyleBackColor = false;
            // 
            // btnPerfil
            // 
            btnPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPerfil.BackColor = Color.Transparent;
            btnPerfil.BackgroundImage = (Image)resources.GetObject("btnPerfil.BackgroundImage");
            btnPerfil.BackgroundImageLayout = ImageLayout.Stretch;
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Location = new Point(2744, 73);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(30, 29);
            btnPerfil.TabIndex = 34;
            btnPerfil.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarSesion.BackColor = Color.Transparent;
            btnCerrarSesion.BackgroundImage = (Image)resources.GetObject("btnCerrarSesion.BackgroundImage");
            btnCerrarSesion.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Location = new Point(2791, 71);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(35, 33);
            btnCerrarSesion.TabIndex = 35;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Controls.Add(button7);
            panel5.Controls.Add(button8);
            panel5.Controls.Add(button9);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(cmbMostrar);
            panel5.Controls.Add(txtBuscar);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(60, 125);
            panel5.Name = "panel5";
            panel5.Size = new Size(1024, 85);
            panel5.TabIndex = 34;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom;
            button7.BackColor = Color.Red;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(552, 31);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(78, 25);
            button7.TabIndex = 51;
            button7.Text = "PDF";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Bottom;
            button8.BackColor = Color.DarkOrange;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(370, 31);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(78, 25);
            button8.TabIndex = 49;
            button8.Text = "Imprimir";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom;
            button9.BackColor = Color.FromArgb(0, 192, 0);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Location = new Point(461, 31);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(78, 25);
            button9.TabIndex = 50;
            button9.Text = "Excel ";
            button9.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(116, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 47;
            label1.Text = "Mostrar";
            // 
            // cmbMostrar
            // 
            cmbMostrar.Anchor = AnchorStyles.Bottom;
            cmbMostrar.BackColor = SystemColors.Info;
            cmbMostrar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMostrar.FormattingEnabled = true;
            cmbMostrar.Items.AddRange(new object[] { "3", "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" });
            cmbMostrar.Location = new Point(179, 28);
            cmbMostrar.Margin = new Padding(2);
            cmbMostrar.Name = "cmbMostrar";
            cmbMostrar.Size = new Size(77, 23);
            cmbMostrar.TabIndex = 46;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Bottom;
            txtBuscar.BackColor = SystemColors.Info;
            txtBuscar.Location = new Point(736, 29);
            txtBuscar.Margin = new Padding(2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(172, 23);
            txtBuscar.TabIndex = 44;
            txtBuscar.TextChanged += txtBuscar_TextChanged_1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(260, 31);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 48;
            label3.Text = "registros";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(676, 31);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 45;
            label4.Text = "Buscar:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtPaginacion);
            panel3.Controls.Add(cmbPaginacion);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtPag);
            panel3.Controls.Add(cmbPag);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(60, 485);
            panel3.Name = "panel3";
            panel3.Size = new Size(1024, 76);
            panel3.TabIndex = 36;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(898, 19);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 51;
            label6.Text = "De";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(770, 19);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 50;
            label7.Text = "Página";
            // 
            // txtPaginacion
            // 
            txtPaginacion.Anchor = AnchorStyles.Right;
            txtPaginacion.Location = new Point(925, 16);
            txtPaginacion.Name = "txtPaginacion";
            txtPaginacion.Size = new Size(65, 23);
            txtPaginacion.TabIndex = 49;
            // 
            // cmbPaginacion
            // 
            cmbPaginacion.Anchor = AnchorStyles.Right;
            cmbPaginacion.BackColor = SystemColors.Info;
            cmbPaginacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaginacion.FormattingEnabled = true;
            cmbPaginacion.Location = new Point(818, 16);
            cmbPaginacion.Margin = new Padding(2);
            cmbPaginacion.Name = "cmbPaginacion";
            cmbPaginacion.Size = new Size(65, 23);
            cmbPaginacion.TabIndex = 48;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(1722, 7);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 47;
            label2.Text = "De";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(1594, 7);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 46;
            label5.Text = "Página";
            // 
            // txtPag
            // 
            txtPag.Anchor = AnchorStyles.Right;
            txtPag.Location = new Point(1749, 4);
            txtPag.Name = "txtPag";
            txtPag.Size = new Size(65, 23);
            txtPag.TabIndex = 45;
            // 
            // cmbPag
            // 
            cmbPag.Anchor = AnchorStyles.Right;
            cmbPag.BackColor = SystemColors.Info;
            cmbPag.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPag.FormattingEnabled = true;
            cmbPag.Location = new Point(1642, 4);
            cmbPag.Margin = new Padding(2);
            cmbPag.Name = "cmbPag";
            cmbPag.Size = new Size(65, 23);
            cmbPag.TabIndex = 44;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvUsuarios);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(60, 210);
            panel4.Name = "panel4";
            panel4.Size = new Size(1024, 275);
            panel4.TabIndex = 37;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(252, 222, 73);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.ColumnHeadersHeight = 30;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.SteelBlue;
            dgvUsuarios.Location = new Point(0, -2);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(1024, 278);
            dgvUsuarios.TabIndex = 2;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick_1;
            dgvUsuarios.CellPainting += dgvUsuarios_CellPainting_1;
            // 
            // CtrlUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1084, 561);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(680, 500);
            Name = "CtrlUsuarios";
            Text = "CtrlUsuarios";
            WindowState = FormWindowState.Maximized;
            Load += CtrlUsuarios_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Button button2;
        private Button button5;
        private Button btnPerfil;
        private Button btnCerrarSesion;
        private Button btnNuevo;
        private Label label11;
        private Panel panel5;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private ComboBox cmbMostrar;
        private TextBox txtBuscar;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private Label label2;
        private Label label5;
        private TextBox txtPag;
        private ComboBox cmbPag;
        private Panel panel4;
        private DataGridView dgvUsuarios;
        private Label label6;
        private Label label7;
        private TextBox txtPaginacion;
        private ComboBox cmbPaginacion;
    }
}