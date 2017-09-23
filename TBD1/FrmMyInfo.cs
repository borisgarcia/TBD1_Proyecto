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
    public partial class FrmMyInfo : Form
    {
        public FrmMyInfo()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmAfiliado cu = new FrmAfiliado();
            cu.lblUser.Text = lblUser.Text;
            this.Hide();
            cu.Closed += (s, args) => this.Close();
            cu.Show();
        }

        private void FrmMyInfo_Load(object sender, EventArgs e)
        {
            int x;
            OdbcConnection con = TBD1.AseConnection.Connect();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "execute SP_Read_Emp @username ='" + lblUser.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
            x = Convert.ToInt32(dt.Rows.Count.ToString());
            dt.Columns["codigo_empleado"].ColumnName = "Codigo Empleado";
            dt.Columns["primer_nombre"].ColumnName = "Primer Nombre";
            dt.Columns["segundo_nombre"].ColumnName = "Segundo Nombre";
            dt.Columns["primer_apellido"].ColumnName = "Primer Apellido";
            dt.Columns["segundo_apellido"].ColumnName = "Segundo Apellido";
            dt.Columns["ciudad"].ColumnName = "Ciudad";
            dt.Columns["calle"].ColumnName = "Calle";
            dt.Columns["avenida"].ColumnName = "Avenida";
            dt.Columns["numero_casa"].ColumnName = "#Casa";
            dt.Columns["departamento"].ColumnName = "Departamento";
            dt.Columns["referencia"].ColumnName = "Referencia";
            dt.Columns["fecha_inicio"].ColumnName = "Fecha Inicio";
            dt.Columns["fecha_nacimiento"].ColumnName = "Fecha Nacimiento";
            dt.Columns["fecha_creacion"].ColumnName = "Fecha Creacion";
            dt.Columns["ultima_modificacion"].ColumnName = "Ultima Modificacion";
            dt.Columns["usuario_creador"].ColumnName = "Usuario Creador";
            dt.Columns["usuario_modificador"].ColumnName = "Usuario Modificador";
            dt.Columns["usuario_id_usuario"].ColumnName = "Id Usuario";
            dataGridView1.DataSource = dt;
        }
    }
}
