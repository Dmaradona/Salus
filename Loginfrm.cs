using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HydraSystem2.DAO;
using MetroFramework;

namespace HydraSystem2.Login
{
    public partial class Loginfrm : Form
    {
        DAOConnUsuario users = new DAOConnUsuario();
        private String senha = "";
        private int perm = 0;
        private int autenticou = 0;
        private String usuario = "";
        public int Perm
        {
            get
            {
                return perm;
            }

            set
            {
                perm = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public int Autenticou
        {
            get
            {
                return autenticou;
            }

            set
            {
                autenticou = value;
            }
        }
        public Loginfrm()
        {
            InitializeComponent();
        }

        private void Loginfrm_Load(object sender, EventArgs e)
        {
            box_usuario.Select();
        }

        private void box_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscaUsuariofrm user = new BuscaUsuariofrm(box_usuario.Text);
                user.ShowDialog();
                box_usuario.Text = user.Usuario;
                box_codusuario.Text = user.Codusuario.ToString();
                BuscaSenha();
                box_senha.Select();
            }
        }
        private void BuscaSenha()
        {
            v.DataSource = users.BuscaSenha(box_codusuario.Text);
            if(v.Rows[0].Cells[0].Value == null)
            {
                return;
            }
            senha = v.Rows[0].Cells[0].Value.ToString();
            Perm = Convert.ToInt32(v.Rows[0].Cells[1].Value.ToString());

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (box_codusuario.Text == "0")
            {
                MetroMessageBox.Show(this,"Usuário Inválido", "Falha na Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                box_usuario.Text = "";
                return;
            }
            if (senha == "")
            {
                MetroMessageBox.Show(this,"Senha Inválida", "Falha na Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                box_senha.Text = "";
                return;
            }
            if (senha == box_senha.Text)
            {
                Autenticou = 1;
                usuario = box_usuario.Text;
                Close();
            }
            else
            {
                MetroMessageBox.Show(this,"Senha Inválida", "Falha na Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                box_senha.Text = "";
                return;
            }
        }

        private void btn_salvar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (box_codusuario.Text == "0")
                {
                    MetroMessageBox.Show(this,"Usuário Inválido", "Falha na Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    box_usuario.Text = "";
                    return;
                }
                if (senha == "")
                {
                    MetroMessageBox.Show(this,"Senha Inválida", "Falha na Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    box_senha.Text = "";
                    return;
                }
                if (senha == box_senha.Text)
                {
                    Autenticou = 1;
                    usuario = box_usuario.Text;
                    Close();
                }
                else
                {
                    MetroMessageBox.Show(this,"Senha Inválida", "Falha na Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    box_senha.Text = "";
                    return;
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult r = MetroMessageBox.Show(this,"Deseja Realmente Sair", "Você Está Saindo ...", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (r == DialogResult.No) return;
            Application.Exit();
        }
    }
}
