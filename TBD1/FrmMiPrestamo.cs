using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBD1
{
    public partial class FrmMiPrestamo : Form
    {
        public FrmMiPrestamo()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmAfiliado cu = new FrmAfiliado();

            cu.lblUser.Text = label2.Text;
            this.Hide();
            cu.Closed += (s, args) => this.Close();
            cu.Show();
        }

        private void FrmMiPrestamo_Load(object sender, EventArgs e)
        {
            int x;
            OdbcConnection con = TBD1.AseConnection.Connect();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "execute SP_Read_Prestamo @username =" + label2.Text;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
            x = Convert.ToInt32(dt.Rows.Count.ToString());

            dt.Columns["numero_prestamo"].ColumnName = "Numero Prestamo";
            dt.Columns["periodo"].ColumnName = "Periodo";
            dt.Columns["saldo"].ColumnName = "Saldo";
            dt.Columns["fecha"].ColumnName = "Fecha";
            dt.Columns["monto"].ColumnName = "Monto";
            dt.Columns["tipo_prestamo"].ColumnName = "Tipo Prestamo";
            dt.Columns["fecha_creacion"].ColumnName = "Fecha Creacion";
            dt.Columns["ultima_modificacion"].ColumnName = "Ultima Modificacion";
            dt.Columns["usuario_creador"].ColumnName = "Usuario Creador";
            dt.Columns["usuario_modificador"].ColumnName = "Usuario Modificador";
            dt.Columns["empleado_codigo_empleado"].ColumnName = "Codigo Empleado";
            dt.Columns["cuota"].ColumnName = "Cuota";
            dataGridView1.DataSource = dt;
        }
    }
}
