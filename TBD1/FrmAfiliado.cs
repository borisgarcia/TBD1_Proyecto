using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBD1
{
    public partial class FrmAfiliado : Form
    {
        public FrmAfiliado()
        {
            InitializeComponent();
        }

        private void FrmAfiliado_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMiCuenta cu = new FrmMiCuenta();

            cu.lblUser.Text = lblUser.Text;
            this.Hide();
            cu.Closed += (s, args) => this.Close();
            cu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMyInfo cu = new FrmMyInfo();
            cu.lblUser.Text = lblUser.Text;
            this.Hide();
            cu.Closed += (s, args) => this.Close();
            cu.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            
            this.Hide();
            log.Closed += (s, args) => this.Close();
            log.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMiPrestamo pre = new FrmMiPrestamo();
            pre.label2.Text = lblUser.Text;
            this.Hide();
            pre.Closed += (s, args) => this.Close();
            pre.Show();
        }
    }
}
