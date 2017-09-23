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
    public partial class FrmRolesUsuario : Form
    {
        public FrmRolesUsuario()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmAdmin admin = new FrmAdmin();
            admin.lblUser.Text = lblUser.Text;
            this.Hide();
            admin.Closed += (s, args) => this.Close();
            admin.Show();
        }

        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            if (txtIdRol1.Text != "" || txtIdPriv1.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Create_Privilegios_Rol @id_rol ='" + txtIdRol1.Text + "', @id_privilegio =" + txtIdPriv1.Text + ",@creador ='" + lblUser.Text + "',@modificador ='" + lblUser.Text + "'";
                cmd.ExecuteNonQuery();

                TBD1.AseConnection.messageBox("Guardado Exitosamente.");
                txtIdRol1.Text = "";
                txtIdPriv1.Text = "";
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            if (txtIdUsuario2.Text != "" || txtIdRol2.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Create_Usuario_Rol @id_usuario =" + txtIdUsuario2.Text + ", @id_rol =" + txtIdRol2.Text + ",@creador ='" + lblUser.Text + "',@modificador ='" + lblUser.Text + "'";
                cmd.ExecuteNonQuery();

                TBD1.AseConnection.messageBox("Guardado Exitosamente.");
                txtIdUsuario2.Text = "";
                txtIdRol2.Text = "";
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            if (txtRolEliminar1.Text != "" || txtEliminarPriv1.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Delete_Privilegios_Rol @rol_id_rol ='" + txtRolEliminar1.Text + "', @id_privilegio =" + txtEliminarPriv1.Text + ",@creador ='" + lblUser.Text + "',@modificador ='" + lblUser.Text + "'";
                cmd.ExecuteNonQuery();

                TBD1.AseConnection.messageBox("Eliminado Exitosamente.");
                txtRolEliminar1.Text = "";
                txtEliminarPriv1.Text = "";
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            if (txtEliminarUsuario2.Text != "" || txtRolEliminar2.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Delete_Usuario_Roles @rol_id_rol ='" + txtEliminarUsuario2.Text + "', @id_privilegio =" + txtRolEliminar2.Text + ",@creador ='" + lblUser.Text + "',@modificador ='" + lblUser.Text + "'";
                cmd.ExecuteNonQuery();

                TBD1.AseConnection.messageBox("Eliminado Exitosamente.");
                txtEliminarUsuario2.Text = "";
                txtRolEliminar2.Text = "";
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        private void btnMod1_Click(object sender, EventArgs e)
        {
            /*if (txtIdRolMod1.Text != "" || txtIdPrivMod1.Text != "")
            {
                int x;
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "execute SP_READ_EMPLEADO_CORREO @CODIGO =" + txtIdRolMod1.Text + ", @CORREO ='" + txtIdPrivMod1.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                x = Convert.ToInt32(dt.Rows.Count.ToString());
                if (x == 0)
                    TBD1.AseConnection.messageBox("Registro no Existe.");

                else
                {
                    btnGuardarMod1.Enabled = true;
                    btnMod1.Enabled = false;
                }
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");*/
        }
    }
}
