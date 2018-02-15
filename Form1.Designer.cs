namespace HydraSystem2
{
    partial class Form1
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
            this.btn_agenda = new MetroFramework.Controls.MetroTile();
            this.img_agenda = new System.Windows.Forms.PictureBox();
            this.btn_paciente = new MetroFramework.Controls.MetroTile();
            this.img_pacientes = new System.Windows.Forms.PictureBox();
            this.btn_financeiro = new MetroFramework.Controls.MetroTile();
            this.img_financeiro = new System.Windows.Forms.PictureBox();
            this.btn_tabelas = new MetroFramework.Controls.MetroTile();
            this.img_tabelas = new System.Windows.Forms.PictureBox();
            this.btn_agenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_agenda)).BeginInit();
            this.btn_paciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_pacientes)).BeginInit();
            this.btn_financeiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_financeiro)).BeginInit();
            this.btn_tabelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_tabelas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_agenda
            // 
            this.btn_agenda.ActiveControl = null;
            this.btn_agenda.Controls.Add(this.img_agenda);
            this.btn_agenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agenda.Location = new System.Drawing.Point(22, 36);
            this.btn_agenda.Name = "btn_agenda";
            this.btn_agenda.Size = new System.Drawing.Size(152, 76);
            this.btn_agenda.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_agenda.TabIndex = 2;
            this.btn_agenda.Text = "Agenda";
            this.btn_agenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agenda.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_agenda.UseSelectable = true;
            this.btn_agenda.Click += new System.EventHandler(this.btn_agenda_Click);
            // 
            // img_agenda
            // 
            this.img_agenda.BackColor = System.Drawing.Color.Transparent;
            this.img_agenda.Dock = System.Windows.Forms.DockStyle.Right;
            this.img_agenda.Image = global::HydraSystem2.Properties.Resources.icon_calendar;
            this.img_agenda.Location = new System.Drawing.Point(72, 0);
            this.img_agenda.Name = "img_agenda";
            this.img_agenda.Size = new System.Drawing.Size(80, 76);
            this.img_agenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_agenda.TabIndex = 0;
            this.img_agenda.TabStop = false;
            this.img_agenda.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_paciente
            // 
            this.btn_paciente.ActiveControl = null;
            this.btn_paciente.Controls.Add(this.img_pacientes);
            this.btn_paciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_paciente.Location = new System.Drawing.Point(180, 36);
            this.btn_paciente.Name = "btn_paciente";
            this.btn_paciente.Size = new System.Drawing.Size(172, 76);
            this.btn_paciente.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_paciente.TabIndex = 3;
            this.btn_paciente.TabStop = false;
            this.btn_paciente.Text = "Parceiros";
            this.btn_paciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_paciente.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_paciente.UseSelectable = true;
            this.btn_paciente.Click += new System.EventHandler(this.btn_paciente_Click);
            // 
            // img_pacientes
            // 
            this.img_pacientes.BackColor = System.Drawing.Color.Transparent;
            this.img_pacientes.Dock = System.Windows.Forms.DockStyle.Right;
            this.img_pacientes.Image = global::HydraSystem2.Properties.Resources.group_users_13234;
            this.img_pacientes.Location = new System.Drawing.Point(92, 0);
            this.img_pacientes.Name = "img_pacientes";
            this.img_pacientes.Size = new System.Drawing.Size(80, 76);
            this.img_pacientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_pacientes.TabIndex = 0;
            this.img_pacientes.TabStop = false;
            this.img_pacientes.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btn_financeiro
            // 
            this.btn_financeiro.ActiveControl = null;
            this.btn_financeiro.Controls.Add(this.img_financeiro);
            this.btn_financeiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_financeiro.Location = new System.Drawing.Point(358, 36);
            this.btn_financeiro.Name = "btn_financeiro";
            this.btn_financeiro.Size = new System.Drawing.Size(172, 76);
            this.btn_financeiro.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_financeiro.TabIndex = 4;
            this.btn_financeiro.TabStop = false;
            this.btn_financeiro.Text = "Financeiro";
            this.btn_financeiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_financeiro.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_financeiro.UseSelectable = true;
            this.btn_financeiro.Click += new System.EventHandler(this.btn_financeiro_Click);
            // 
            // img_financeiro
            // 
            this.img_financeiro.BackColor = System.Drawing.Color.Transparent;
            this.img_financeiro.Dock = System.Windows.Forms.DockStyle.Right;
            this.img_financeiro.Image = global::HydraSystem2.Properties.Resources.dollar_light;
            this.img_financeiro.Location = new System.Drawing.Point(92, 0);
            this.img_financeiro.Name = "img_financeiro";
            this.img_financeiro.Size = new System.Drawing.Size(80, 76);
            this.img_financeiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_financeiro.TabIndex = 0;
            this.img_financeiro.TabStop = false;
            this.img_financeiro.Click += new System.EventHandler(this.img_financeiro_Click);
            // 
            // btn_tabelas
            // 
            this.btn_tabelas.ActiveControl = null;
            this.btn_tabelas.Controls.Add(this.img_tabelas);
            this.btn_tabelas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tabelas.Location = new System.Drawing.Point(536, 36);
            this.btn_tabelas.Name = "btn_tabelas";
            this.btn_tabelas.Size = new System.Drawing.Size(172, 76);
            this.btn_tabelas.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_tabelas.TabIndex = 5;
            this.btn_tabelas.TabStop = false;
            this.btn_tabelas.Text = "Tabelas";
            this.btn_tabelas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tabelas.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_tabelas.UseSelectable = true;
            this.btn_tabelas.Click += new System.EventHandler(this.btn_tabelas_Click);
            // 
            // img_tabelas
            // 
            this.img_tabelas.BackColor = System.Drawing.Color.Transparent;
            this.img_tabelas.Dock = System.Windows.Forms.DockStyle.Right;
            this.img_tabelas.Image = global::HydraSystem2.Properties.Resources.Sketch_Book_icon;
            this.img_tabelas.Location = new System.Drawing.Point(92, 0);
            this.img_tabelas.Name = "img_tabelas";
            this.img_tabelas.Size = new System.Drawing.Size(80, 76);
            this.img_tabelas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_tabelas.TabIndex = 0;
            this.img_tabelas.TabStop = false;
            this.img_tabelas.Click += new System.EventHandler(this.img_tabelas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(918, 322);
            this.Controls.Add(this.btn_tabelas);
            this.Controls.Add(this.btn_financeiro);
            this.Controls.Add(this.btn_paciente);
            this.Controls.Add(this.btn_agenda);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.btn_agenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_agenda)).EndInit();
            this.btn_paciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_pacientes)).EndInit();
            this.btn_financeiro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_financeiro)).EndInit();
            this.btn_tabelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_tabelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile btn_agenda;
        private System.Windows.Forms.PictureBox img_agenda;
        private MetroFramework.Controls.MetroTile btn_paciente;
        private System.Windows.Forms.PictureBox img_pacientes;
        private MetroFramework.Controls.MetroTile btn_financeiro;
        private System.Windows.Forms.PictureBox img_financeiro;
        private MetroFramework.Controls.MetroTile btn_tabelas;
        private System.Windows.Forms.PictureBox img_tabelas;
    }
}

