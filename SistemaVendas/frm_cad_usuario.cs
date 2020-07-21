using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendas
{
    public partial class frm_cad_usuario : Form
    {
        public frm_cad_usuario()
        {
            InitializeComponent();
        }

        private void frm_cad_usuario_Load(object sender, EventArgs e)
        {
            this.Text = ClVariaveisGlobais.vesãoSistema;
        }
    }
}
