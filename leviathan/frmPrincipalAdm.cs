using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leviathan
{
    public partial class frmPrincipalAdm : Form
    {
        public frmPrincipalAdm()
        {
            InitializeComponent();
        }
        DateTime tela;
        private void frmPrincipalAdm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now - tela;
            lblTempo.Text =
                $"Tempo: {ts.Hours.ToString("00")}:" +
                $"{ts.Minutes.ToString("00")}:" +
                $"{ts.Seconds.ToString("00")}";
        }

        private void frmPrincipalAdm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar a aplicação?", "Leviathan",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuFuncionario_Click(object sender, EventArgs e)
        {
            //AbrirForm(new frmFuncionario());
        }
        private void AbrirForm(Form form)
        {
            foreach(Form filho in this.MdiChildren)
            {
                if (filho.Name == form.Name)
                {
                    filho.Activate();
                    return;
                }
            }
            form.MdiParent = this;
            form.Show();
        }

        private void mnuCliente_Click(object sender, EventArgs e)
        {
            //AbrirForm(new frmCliente());
        }

        private void mnuServico_Click(object sender, EventArgs e)
        {
            //AbrirForm(new frmServico());
        }
    }
}
