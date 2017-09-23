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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEmpleado emp = new FrmEmpleado();
            
            emp.lblUser.Text = lblUser.Text;
            this.Hide();
            emp.Closed += (s, args) => this.Close();
            emp.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario user = new FrmUsuario();
            user.lblUser.Text = lblUser.Text;
            this.Hide();
            user.Closed += (s, args) => this.Close();
            user.Show();
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            FrmCuenta cuenta = new FrmCuenta();
            cuenta.lblUser.Text = lblUser.Text;
            this.Hide();
            cuenta.Closed += (s, args) => this.Close();
            cuenta.Show();
        }

        private void btnAbono_Click(object sender, EventArgs e)
        {
            FrmAbono abo = new FrmAbono();
            abo.lblUser.Text = lblUser.Text;
            this.Hide();
            abo.Closed += (s, args) => this.Close();
            abo.Show();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            FrmPago pago = new FrmPago();
            pago.lblUser.Text = lblUser.Text;
            this.Hide();
            pago.Closed += (s, args) => this.Close();
            pago.Show();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            FrmPrestamo pre = new FrmPrestamo();
            pre.lblUser.Text = lblUser.Text;
            this.Hide();
            pre.Closed += (s, args) => this.Close();
            pre.Show();
        }

        private void btnPrivilegios_Click(object sender, EventArgs e)
        {
            FrmPrivilegios pri = new FrmPrivilegios();
            pri.lblUser.Text = lblUser.Text;
            this.Hide();
            pri.Closed += (s, args) => this.Close();
            pri.Show();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            FrmRoles rol = new FrmRoles();
            rol.lblUser.Text = lblUser.Text;
            this.Hide();
            rol.Closed += (s, args) => this.Close();
            rol.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();     
            this.Hide();
            log.Closed += (s, args) => this.Close();
            log.Show();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmRolesUsuario pru = new FrmRolesUsuario();
            pru.lblUser.Text = lblUser.Text;
            this.Hide();
            pru.Closed += (s, args) => this.Close();
            pru.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmEmpleadoTelefono emTel = new FrmEmpleadoTelefono();
            emTel.lblUser.Text = lblUser.Text;
            this.Hide();
            emTel.Closed += (s, args) => this.Close();
            emTel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmNuevosAfiliados emTel = new FrmNuevosAfiliados();
            emTel.lblUser.Text = lblUser.Text;
            this.Hide();
            emTel.Closed += (s, args) => this.Close();
            emTel.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmDividendos emTel = new FrmDividendos();
            emTel.lblUser.Text = lblUser.Text;
            this.Hide();
            emTel.Closed += (s, args) => this.Close();
            emTel.Show();
        }
    }
}
