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
    public partial class FrmMiCuenta : Form
    {
        public FrmMiCuenta()
        {
            InitializeComponent();
        }

        private void FrmMiCuenta_Load(object sender, EventArgs e)
        {
            int x1, x2;

            OdbcConnection con = TBD1.AseConnection.Connect();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "execute SP_Read_Cuenta @username ='" + lblUser.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
            x1 = Convert.ToInt32(dt.Rows.Count.ToString());

            if (x1 != 0)
            {
                dt.Columns["numero_cuenta"].ColumnName = "Numero Cuenta";
                dt.Columns["empleado_codigo_empleado"].ColumnName = "Codigo Empleado";
                dt.Columns["fecha_apertura"].ColumnName = "Fecha Apertura";
                dt.Columns["antiguedad"].ColumnName = "Antiguedad";
                dt.Columns["saldo"].ColumnName = "Saldo";
                dt.Columns["monto_mensual"].ColumnName = "Monto Mensual";
                dt.Columns["tipo_cuenta"].ColumnName = "Tipo Cuenta";
                dt.Columns["fecha_creacion"].ColumnName = "Fecha Creacion";
                dt.Columns["ultima_modificacion"].ColumnName = "Ultima Modificacion";
                dt.Columns["usuario_modificador"].ColumnName = "Usuario Modificador";
                dt.Columns["usuario_creador"].ColumnName = "Usuario Creador";
                dataGridView1.DataSource = dt;
            }

            cmd.CommandText = "execute SP_Read_Abonos @username ='" + lblUser.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            OdbcDataAdapter da2 = new OdbcDataAdapter(cmd);
            da2.Fill(dt2);
            x2 = Convert.ToInt32(dt2.Rows.Count.ToString());
            if (x2 != 0)
            {
                dt2.Columns["numero_abono"].ColumnName = "Numero Abono";
                dt2.Columns["comentario"].ColumnName = "Comentario";
                dt2.Columns["fecha"].ColumnName = "Fecha";
                dt2.Columns["monto"].ColumnName = "Monto";
                dt2.Columns["cuenta_numero_cuenta"].ColumnName = "Numero Cuenta";
                dt2.Columns["fecha_creacion"].ColumnName = "Fecha Creacion";
                dt2.Columns["ultima_modificacion"].ColumnName = "Ultima Modificacion";
                dt2.Columns["usuario_creador"].ColumnName = "Usuario Creador";
                dt2.Columns["usuario_modificador"].ColumnName = "Usuario Modificador";

                dataGridView2.DataSource = dt2;
            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmAfiliado cu = new FrmAfiliado();

            cu.lblUser.Text = lblUser.Text;
            this.Hide();
            cu.Closed += (s, args) => this.Close();
            cu.Show();
        }
    }
}
