namespace HydraSystem2.Login
{
    partial class Loginfrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_salvar = new MetroFramework.Controls.MetroButton();
            this.btn_cancelar = new MetroFramework.Controls.MetroButton();
            this.v = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.box_usuario = new MetroFramework.Controls.MetroTextBox();
            this.box_senha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.box_codusuario = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_salvar.Highlight = true;
            this.btn_salvar.Location = new System.Drawing.Point(78, 193);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(112, 41);
            this.btn_salvar.Style = MetroFramework.MetroColorStyle.Purple;
            this.btn_salvar.TabIndex = 0;
            this.btn_salvar.Text = "Login";
            this.btn_salvar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_salvar.UseCustomBackColor = true;
            this.btn_salvar.UseSelectable = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            this.btn_salvar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_salvar_KeyDown);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btn_cancelar.Highlight = true;
            this.btn_cancelar.Location = new System.Drawing.Point(205, 193);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(112, 41);
            this.btn_cancelar.Style = MetroFramework.MetroColorStyle.Red;
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Sair";
            this.btn_cancelar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_cancelar.UseCustomBackColor = true;
            this.btn_cancelar.UseSelectable = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // v
            // 
            this.v.AllowUserToResizeRows = false;
            this.v.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.v.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.v.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.v.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.v.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.v.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.v.DefaultCellStyle = dataGridViewCellStyle2;
            this.v.EnableHeadersVisualStyles = false;
            this.v.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.v.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.v.Location = new System.Drawing.Point(12, 12);
            this.v.Name = "v";
            this.v.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.v.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.v.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.v.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.v.Size = new System.Drawing.Size(95, 33);
            this.v.TabIndex = 2;
            this.v.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(48, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Usuário";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(48, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Senha";
            // 
            // box_usuario
            // 
            this.box_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.box_usuario.CustomButton.Image = null;
            this.box_usuario.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.box_usuario.CustomButton.Name = "";
            this.box_usuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.box_usuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.box_usuario.CustomButton.TabIndex = 1;
            this.box_usuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.box_usuario.CustomButton.UseSelectable = true;
            this.box_usuario.CustomButton.Visible = false;
            this.box_usuario.Lines = new string[0];
            this.box_usuario.Location = new System.Drawing.Point(107, 70);
            this.box_usuario.MaxLength = 32767;
            this.box_usuario.Name = "box_usuario";
            this.box_usuario.PasswordChar = '\0';
            this.box_usuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.box_usuario.SelectedText = "";
            this.box_usuario.SelectionLength = 0;
            this.box_usuario.SelectionStart = 0;
            this.box_usuario.Size = new System.Drawing.Size(201, 23);
            this.box_usuario.Style = MetroFramework.MetroColorStyle.Purple;
            this.box_usuario.TabIndex = 5;
            this.box_usuario.UseSelectable = true;
            this.box_usuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.box_usuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.box_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.box_usuario_KeyDown);
            // 
            // box_senha
            // 
            // 
            // 
            // 
            this.box_senha.CustomButton.Image = null;
            this.box_senha.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.box_senha.CustomButton.Name = "";
            this.box_senha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.box_senha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.box_senha.CustomButton.TabIndex = 1;
            this.box_senha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.box_senha.CustomButton.UseSelectable = true;
            this.box_senha.CustomButton.Visible = false;
            this.box_senha.Lines = new string[0];
            this.box_senha.Location = new System.Drawing.Point(107, 113);
            this.box_senha.MaxLength = 32767;
            this.box_senha.Name = "box_senha";
            this.box_senha.PasswordChar = '*';
            this.box_senha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.box_senha.SelectedText = "";
            this.box_senha.SelectionLength = 0;
            this.box_senha.SelectionStart = 0;
            this.box_senha.Size = new System.Drawing.Size(201, 23);
            this.box_senha.Style = MetroFramework.MetroColorStyle.Purple;
            this.box_senha.TabIndex = 6;
            this.box_senha.UseSelectable = true;
            this.box_senha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.box_senha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.box_senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_salvar_KeyDown);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(234, 9);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 25);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Autenticação";
            // 
            // box_codusuario
            // 
            // 
            // 
            // 
            this.box_codusuario.CustomButton.Image = null;
            this.box_codusuario.CustomButton.Location = new System.Drawing.Point(179, 1);
            this.box_codusuario.CustomButton.Name = "";
            this.box_codusuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.box_codusuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.box_codusuario.CustomButton.TabIndex = 1;
            this.box_codusuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.box_codusuario.CustomButton.UseSelectable = true;
            this.box_codusuario.CustomButton.Visible = false;
            this.box_codusuario.Lines = new string[] {
        "0"};
            this.box_codusuario.Location = new System.Drawing.Point(343, 19);
            this.box_codusuario.MaxLength = 32767;
            this.box_codusuario.Name = "box_codusuario";
            this.box_codusuario.PasswordChar = '\0';
            this.box_codusuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.box_codusuario.SelectedText = "";
            this.box_codusuario.SelectionLength = 0;
            this.box_codusuario.SelectionStart = 0;
            this.box_codusuario.Size = new System.Drawing.Size(201, 23);
            this.box_codusuario.TabIndex = 9;
            this.box_codusuario.Text = "0";
            this.box_codusuario.UseSelectable = true;
            this.box_codusuario.Visible = false;
            this.box_codusuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.box_codusuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HydraSystem2.Properties.Resources._11942831_ocp_logo_icon;
            this.pictureBox1.Location = new System.Drawing.Point(348, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Loginfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(568, 252);
            this.Controls.Add(this.box_codusuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.box_senha);
            this.Controls.Add(this.box_usuario);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.v);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loginfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loginfrm";
            this.Load += new System.EventHandler(this.Loginfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_salvar;
        private MetroFramework.Controls.MetroButton btn_cancelar;
        private MetroFramework.Controls.MetroGrid v;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox box_usuario;
        private MetroFramework.Controls.MetroTextBox box_senha;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox box_codusuario;
    }
}