using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceGrafica
{
    public partial class FrmModeloDeCadastro : Form
    {
        public String operacao;

        public FrmModeloDeCadastro()
        {
            InitializeComponent();
        }

        public void alterabotoes(int op)
        {
            pndados.Enabled = false;
            btCadastra.Enabled = false;
            btCancelar.Enabled = false;
            btExcluir.Enabled = false;
            btLocalizar.Enabled = false;
            btSalvar.Enabled = false;
            btAlterar.Enabled = false;

            if(op == 1)
            {
                btCadastra.Enabled = true;
                btLocalizar.Enabled = true;
            }

            if(op == 2)
            {
                pndados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;

            }

            if(op == 3)
            {
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;

            }
        }

        private void FrmModeloDeCadastro_Load(object sender, EventArgs e)
        {
            this.alterabotoes(1);
        }
    }
}
