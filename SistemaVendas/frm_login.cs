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
            String nome_digitado = txt_usuario.Text;
            String senha_digitada = txt_senha.Text;
            String senha_banco = "";

            ClVariaveisGlobais.conexao.ConnectionString = ClVariaveisGlobais.conecta;
            OleDbCommand comando = new OleDbCommand("SELECT * FROM tbUsuarios where nome='" + nome_digitado + "'");
            comando.Connection = ClVariaveisGlobais.conexao;
            ClVariaveisGlobais.conexao.Open();
            OleDbDataReader leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                senha_banco = leitor.GetString(1);
            }
            ClVariaveisGlobais.conexao.Close();

            if (senha_banco == senha_digitada)
            {
                frm_principal mostrar_Principal = new frm_principal();
                mostrar_Principal.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Usuário ou Senha Incorretos");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
