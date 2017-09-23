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
    public partial class FrmRoles : Form
    {
        public FrmRoles()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Create_Rol @descripcion ='" + txtDescripcion.Text + "',@u_creador ='" + lblUser.Text + "',@u_modificador ='" + lblUser.Text + "'";
                cmd.ExecuteNonQuery();

                TBD1.AseConnection.messageBox("Guardado Exitosamente.");
                txtDescripcion.Text = "";
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmAdmin admin = new FrmAdmin();
            admin.lblUser.Text = lblUser.Text;
            this.Hide();
            admin.Closed += (s, args) => this.Close();
            admin.Show();
        }

        private void btnBuscarMod_Click_1(object sender, EventArgs e)
        {
            if (txtParamMod.Text != "")
            {
                int x;
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "execute SP_READ_ROL @id =" + txtParamMod.Text;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                x = Convert.ToInt32(dt.Rows.Count.ToString());
                if (x == 0)
                    TBD1.AseConnection.messageBox("Registro no Existe.");

                else
                {
                    txtDescripcion2.Text = dt.Rows[0]["descripcion_rol"].ToString();
                    txtDescripcion2.Enabled = true;
                    txtParamMod.Enabled = false;
                    btnBuscarMod.Enabled = false;
                    btnGuardarMod.Enabled = true;
                }
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        private void btnGuardarMod_Click(object sender, EventArgs e)
        {
            if (txtDescripcion2.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Update_Rol @id_rol = " + txtParamMod.Text+ ",@descripcion = '" + txtDescripcion2.Text + "',@u_modificador = '" + lblUser.Text+"'";
                cmd.ExecuteNonQuery();

                TBD1.AseConnection.messageBox("Guardado Exitosamente.");
                txtDescripcion.Text = "";
                txtParamMod.Text = "";
                txtDescripcion2.Enabled = false;
                txtParamMod.Enabled = true;
                btnBuscarMod.Enabled = true;
                btnGuardarMod.Enabled = false;
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            int x;
            OdbcConnection con = TBD1.AseConnection.Connect();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "execute SP_READ_ROL @id =" + txtParamBuscar.Text;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
            x = Convert.ToInt32(dt.Rows.Count.ToString());
            if (x == 0)
                TBD1.AseConnection.messageBox("Registro No Existe.");
            else
            {
                dt.Columns["id_rol"].ColumnName = "Id Rol";
                dt.Columns["descripcion_rol"].ColumnName = "Descripcion";
                dt.Columns["fecha_creacion"].ColumnName = "Fecha Creacion";
                dt.Columns["ultima_modificacion"].ColumnName = "Ultima Modificacion";
                dt.Columns["usuario_creador"].ColumnName = "Usuario Creador";
                dt.Columns["usuario_modificador"].ColumnName = "Usuario Modificador";
                dataGridView1.DataSource = dt;

            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int x;
            OdbcConnection con = TBD1.AseConnection.Connect();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "execute SP_READ_ROL @id =" + txtParamEliminar.Text;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
            x = Convert.ToInt32(dt.Rows.Count.ToString());
            if (x == 1)
            {
                TBD1.AseConnection.messageBox("Registro Eliminado Exitosamente!");
                cmd.CommandText = "execute SP_Delete_Rol @id =" + txtParamEliminar.Text;
                cmd.ExecuteNonQuery();
                txtParamEliminar.Text = "";
            }
            else
            {
                TBD1.AseConnection.messageBox("Registro no Existe!");
                txtParamEliminar.Text = "";
            }
        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {

        }
    }
}
