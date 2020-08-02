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
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClVariaveisGlobais.conexao.ConnectionString = ClVariaveisGlobais.conecta;

            OleDbCommand comando = new OleDbCommand("INSERT INTO tbUsuarios(nome, senha) VALUES ('" + txt_nome_cadastro.Text + "','" + txt_senha_cadastro.Text + "')");
            comando.Connection = ClVariaveisGlobais.conexao;
            ClVariaveisGlobais.conexao.Open();
            comando.ExecuteNonQuery();
            ClVariaveisGlobais.conexao.Close();
            MessageBox.Show("Dados Cadastrados Com Sucesso!");
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            this.Text = ClVariaveisGlobais.vesãoSistema;
        }

        private void frm_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClVariaveisGlobais.conexao.ConnectionString = ClVariaveisGlobais.conecta;

            OleDbCommand comando = new OleDbCommand("DELETE FROM tbUsuarios WHERE nome='" + txt_nome_apagar.Text + "'");
            comando.Connection = ClVariaveisGlobais.conexao;
            ClVariaveisGlobais.conexao.Open();
            comando.ExecuteNonQuery();
            ClVariaveisGlobais.conexao.Close();
            MessageBox.Show("Dados Apagados Com Sucesso!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClVariaveisGlobais.conexao.ConnectionString = ClVariaveisGlobais.conecta;

            OleDbCommand comando = new OleDbCommand("UPDATE tbUsuarios SET senha='" + txt_senha_editar.Text + "' WHERE nome='"+ txt_nome_editar.Text + "'");
            comando.Connection = ClVariaveisGlobais.conexao;
            ClVariaveisGlobais.conexao.Open();
            comando.ExecuteNonQuery();
            ClVariaveisGlobais.conexao.Close();
            MessageBox.Show("Dados Editados Com Sucesso!");
        }
    }
}
