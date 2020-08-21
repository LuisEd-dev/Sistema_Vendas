using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaVendas
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            this.Text = ClVariaveisGlobais.vesãoSistema;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nome_digitado, nome_banco;
            String senha_digitada, senha_banco;

            nome_digitado = txt_usuario.Text;
            senha_digitada = txt_senha.Text;
            senha_banco = "";

            ClVariaveisGlobais.conexao.ConnectionString = ClVariaveisGlobais.conecta;
            OleDbCommand comando =
                new OleDbCommand("SELECT * FROM tbUsuarios WHERE nome='" + nome_digitado + "'");
            comando.Connection = ClVariaveisGlobais.conexao;
            ClVariaveisGlobais.conexao.Open();
            OleDbDataReader leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                nome_banco = leitor.GetString(0);
                senha_banco = leitor.GetString(1);
            }
            ClVariaveisGlobais.conexao.Close();

            if (senha_digitada == senha_banco & senha_banco != "")
            {
                frm_principal mostrarTelaPrincipal = new frm_principal();
                mostrarTelaPrincipal.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Usuário ou senha incorretos.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
