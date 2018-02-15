using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HydraSystem2.Login;
using HydraSystem2.Paciente;
using HydraSystem2.Agenda;
using System.Threading;
using HydraSystem2.Financeiro;
using HydraSystem2.Tabelas;
using HydraSystem2.Parceiro;

namespace HydraSystem2
{
    public partial class Form1 : Form
    {
        private int permissaousuario = 0;
        private String usuario = "";
        Thread cadastropaciente, mainPacientes, mainFinanceiro, mainTabelas;
        public int Permissaousuario
        {
            get
            {
                return permissaousuario;
            }

            set
            {
                permissaousuario = value;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loginfrm login = new Loginfrm();
            login.ShowDialog();
            if (login.Autenticou == 0) Application.Exit();
            Usuario = login.Usuario;
            Permissaousuario = login.Perm;
        }

        private void mainPaciente()
        {
            MainParceirofrm mp = new MainParceirofrm();
            mp.ShowDialog();
            mainPacientes.Abort();
        }

        private void MainFinanceiro() {
            MainFinanceirofrm mf = new MainFinanceirofrm();
            mf.ShowDialog();
            mainFinanceiro.Abort();
        }

        private void btn_agenda_Click(object sender, EventArgs e)
        {
            Agendafrm ag = new Agendafrm(this);
            ag.ShowDialog();
        }

        private void MainTabelas() {
            MainTabelasfrm mt = new MainTabelasfrm();
            mt.ShowDialog();
            mainTabelas.Abort();
        }

        private void btn_paciente_Click(object sender, EventArgs e)
        {
            mainPacientes = new Thread(mainPaciente);
            mainPacientes.Start();
        }

        private void btn_financeiro_Click(object sender, EventArgs e)
        {
            mainFinanceiro = new Thread(MainFinanceiro);
            mainFinanceiro.Start();
        }

        private void btn_tabelas_Click(object sender, EventArgs e)
        {
            mainTabelas = new Thread(MainTabelas);
            mainTabelas.Start();
        }

        private void img_tabelas_Click(object sender, EventArgs e)
        {
            btn_tabelas_Click(sender, e);
        }

        private void img_financeiro_Click(object sender, EventArgs e)
        {
            btn_financeiro_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btn_agenda_Click(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btn_paciente_Click(sender, e);
        }
    }
}
