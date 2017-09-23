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
    public partial class FrmAbono : Form
    {
        public FrmAbono()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNumCuenta.Text != "" || txtComentario.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Create_Abono @comentario ='" + txtComentario.Text + "', @numero_cuenta =" + txtNumCuenta.Text + ",@creador ='" + lblUser.Text + "',@modificador ='" + lblUser.Text + "'";
                cmd.ExecuteNonQuery();

                TBD1.AseConnection.messageBox("Guardado Exitosamente.");
                txtNumCuenta.Text = "";
                txtComentario.Text = "";
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        private void btnBuscarMod_Click(object sender, EventArgs e)
        {
            if (txtParamMod.Text != "")
            {
                int x;
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "execute SP_READ_ABONO @id =" + txtParamMod.Text+", @param_2 =" + txtNumCuenta2.Text;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                x = Convert.ToInt32(dt.Rows.Count.ToString());
                if (x == 0)
                    TBD1.AseConnection.messageBox("Registro no Existe.");
                
                else
                {
                    txtComentario2.Text = dt.Rows[0]["comentario"].ToString();
                    txtParamMod.Text = "";
                    txtNumCuenta2.Text = "";
                    txtComentario2.Enabled = true;
                    txtNumCuenta2.Enabled = false;
                    txtParamMod.Enabled = false;
                    btnBuscarMod.Enabled = false;
                    btnGuardarMod.Enabled = true;
                }
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtComentario2.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Update_Abono @comentario ='" + txtComentario2.Text + "',@u_modificador ='" + lblUser.Text + "@id = " + txtParamMod.Text+", @param_2 = " + txtNumCuenta2.Text;
                cmd.ExecuteNonQuery();

                TBD1.AseConnection.messageBox("Guardado Exitosamente.");
                txtNumCuenta.Text = "";
                txtComentario.Text = "";
                txtComentario2.Enabled = false;
                txtNumCuenta2.Enabled = true;
                txtParamMod.Enabled = true;
                btnBuscarMod.Enabled = true;
                btnGuardarMod.Enabled = false;
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int x;
            OdbcConnection con = TBD1.AseConnection.Connect();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "execute SP_READ_ABONO2 @id =" + txtParamBuscar.Text;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
            x = Convert.ToInt32(dt.Rows.Count.ToString());
            if (x == 0)
                TBD1.AseConnection.messageBox("Registro No Existe.");
            else
            {
                dt.Columns["numero_abono"].ColumnName = "Numero Abono";
                dt.Columns["comentario"].ColumnName = "Comentario";
                dt.Columns["fecha"].ColumnName = "Fecha";
                dt.Columns["monto"].ColumnName = "Monto";
                dt.Columns["cuenta_numero_cuenta"].ColumnName = "Numero Cuenta";
                dt.Columns["fecha_creacion"].ColumnName = "Fecha Creacion";
                dt.Columns["ultima_modificacion"].ColumnName = "Ultima Modificacion";
                dt.Columns["usuario_creador"].ColumnName = "Usuario Creador";
                dt.Columns["usuario_modificador"].ColumnName = "Usuario Modificador";

                dataGridView1.DataSource = dt;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int x;
            OdbcConnection con = TBD1.AseConnection.Connect();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "execute SP_READ_ABONO @id =" + txtParamEliminar.Text+ ",@param_2 = " + txtParamEliminar2.Text;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
            x = Convert.ToInt32(dt.Rows.Count.ToString());
            if (x == 1)
            {
                TBD1.AseConnection.messageBox("Registro Eliminado Exitosamente!");
                cmd.CommandText = "execute SP_Delete_Abono @id =" + txtParamEliminar.Text + ",@param_1 = " + txtParamEliminar2.Text;
                cmd.ExecuteNonQuery();
                txtParamEliminar.Text = "";
                txtParamEliminar2.Text = "";
            }
            else
            {
                TBD1.AseConnection.messageBox("Registro no Existe!");
                txtParamEliminar.Text = "";
                txtParamEliminar2.Text = "";
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmAdmin admin = new FrmAdmin();
            admin.lblUser.Text = lblUser.Text;
            this.Hide();
            admin.Closed += (s, args) => this.Close();
            admin.Show();
        }

        private void FrmAbono_Load(object sender, EventArgs e)
        {

        }
    }
}
