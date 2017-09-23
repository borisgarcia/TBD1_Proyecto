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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }
        //Nuevo
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text != "" || txtUsername.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Create_Usuario @username =" + txtUsername.Text + ", @contrasena =" + txtContrasena.Text + ",@u_creador ='" + lblUser.Text + "',@u_modificador ='" + lblUser.Text + "'";
                cmd.ExecuteNonQuery();

                TBD1.AseConnection.messageBox("Guardado Exitosamente.");
                txtUsername.Text = "";
                txtContrasena.Text = "";
            }
            else
            {
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
            }
        }

        //Modificar
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtParam1.Text != "")
            {
                int x;
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "execute SP_READ_USUARIO2 @id =" + txtParam1.Text;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                x = Convert.ToInt32(dt.Rows.Count.ToString());
                if (x == 0)
                {
                    TBD1.AseConnection.messageBox("Usuario No Existe.");
                    txtParam1.Text = "";
                }
                else
                {
                    txtUser.Text = dt.Rows[0]["username"].ToString();
                    txtContra.Text = dt.Rows[0]["contrasena"].ToString();
                    txtParam1.Text = "";
                    txtUsername.Enabled = true;
                    txtContrasena.Enabled = true;
                    txtParam1.Enabled = false;
                }
            }
            else
            {
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
            }
        }


        //Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int x;
            OdbcConnection con = TBD1.AseConnection.Connect();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "execute SP_READ_USUARIO2 @id =" + txtParam1.Text;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
            x = Convert.ToInt32(dt.Rows.Count.ToString());
            if (x == 0)
            {
                TBD1.AseConnection.messageBox("Usuario No Existe.");
                txtParam1.Text = "";
            }
            else
            {
                dt.Columns["id_usuario"].ColumnName = "Id Usuario";
                dt.Columns["username"].ColumnName = "Username";
                dt.Columns["contrasena"].ColumnName = "Contrasena";
                dt.Columns["fecha_creacion"].ColumnName = "Fecha Creacion";
                dt.Columns["ultima_modificacion"].ColumnName = "Ultima Modificacion";
                dt.Columns["usuario_creador"].ColumnName = "Usuario Creador";
                dt.Columns["usuario_modificador"].ColumnName = "Usuario Modificador";

                dataGridView1.DataSource = dt;
                txtParam1.Text = "";
            }
        }

        //Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int x;
            OdbcConnection con = TBD1.AseConnection.Connect();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "execute SP_READ_USUARIO2 @id =" + txtParamEliminar.Text;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
            x = Convert.ToInt32(dt.Rows.Count.ToString());
            if (x == 1)
            {
                TBD1.AseConnection.messageBox("Registro Eliminado Exitosamente!");
                cmd.CommandText = "execute SP_Delete_Usuario @id =" + txtParamEliminar.Text;
                cmd.ExecuteNonQuery();
                txtParamEliminar.Text = "";

            }
            else
            {
                TBD1.AseConnection.messageBox("Registro no Existe!");
                txtParamEliminar.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OdbcConnection con = TBD1.AseConnection.Connect();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "execute SP_Update_Usuario @id_usuario =" + txtParam1.Text + ",@username =" + txtUsername.Text + ", @contrasena =" + txtContrasena.Text + ",@u_modificador ='" + lblUser.Text + "'";
            cmd.ExecuteNonQuery();

            TBD1.AseConnection.messageBox("Guardado Exitosamente.");
            txtParam1.Text = "";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmAdmin admin = new FrmAdmin();
            admin.lblUser.Text = lblUser.Text;
            this.Hide();
            admin.Closed += (s, args) => this.Close();
            admin.Show();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            int x;
            OdbcConnection con = TBD1.AseConnection.Connect();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "execute SP_READ_USUARIO2 @id =" + txtParam.Text;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
            x = Convert.ToInt32(dt.Rows.Count.ToString());
            if (x == 0)
            {
                TBD1.AseConnection.messageBox("Usuario No Existe.");
                txtParam1.Text = "";
            }
            else
            {
                dt.Columns["id_usuario"].ColumnName = "Id Usuario";
                dt.Columns["username"].ColumnName = "Username";
                dt.Columns["contrasena"].ColumnName = "Contrasena";
                dt.Columns["fecha_creacion"].ColumnName = "Fecha Creacion";
                dt.Columns["ultima_modificacion"].ColumnName = "Ultima Modificacion";
                dt.Columns["usuario_creador"].ColumnName = "Usuario Creador";
                dt.Columns["usuario_modificador"].ColumnName = "Usuario Modificador";

                dataGridView1.DataSource = dt;
                txtParam1.Text = "";
            }
        }
    }
}
