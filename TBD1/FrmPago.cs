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
    public partial class FrmPago : Form
    {
        public FrmPago()
        {
            InitializeComponent();
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNumPres.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Create_Pagos @numero_pres =" + txtNumPres.Text + ",@creador ='" + lblUser.Text + "',@modificador ='" + lblUser.Text + "'";
                cmd.ExecuteNonQuery();

                TBD1.AseConnection.messageBox("Guardado Exitosamente.");
                txtNumPres.Text = "";
            }
            else
                TBD1.AseConnection.messageBox("Debe el campo.");
        }

        private void btnBuscarMod_Click(object sender, EventArgs e)
        {
            if (txtParamMod.Text != "" || txtParamMod2.Text != "")
            {
                int x;
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "execute SP_READ_PAGOS2 @id =" + txtParamMod.Text + ", @num_pres =" + txtParamMod2.Text;
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OdbcDataAdapter da = new OdbcDataAdapter(cmd);
                da.Fill(dt);
                x = Convert.ToInt32(dt.Rows.Count.ToString());
                if (x == 0)
                    TBD1.AseConnection.messageBox("Registro no Existe.");

                else
                {
                    txtNumPres2.Text = dt.Rows[0]["prestamos_numero_prestamo"].ToString();
                    txtParamMod.Text = "";
                    txtParamMod2.Text = "";                   
                    txtParamMod.Enabled = false;
                    txtParamMod2.Enabled = false;
                    txtNumPres2.Enabled = true;
                    btnBuscarMod.Enabled = false;
                    btnGuardarMod.Enabled = true;
                }
            }
            else
                TBD1.AseConnection.messageBox("Debe llenar todos los campos.");
        }

        private void btnGuardarMod_Click(object sender, EventArgs e)
        {
            if (txtNumPres2.Text != "")
            {
                OdbcConnection con = TBD1.AseConnection.Connect();
                OdbcCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "execute SP_Update_pagos @numero_pago =" + txtParamMod.Text + ",@modificador ='" + lblUser.Text + ",@num_prestamo" + txtNumPres2.Text;
                cmd.ExecuteNonQuery();

                TBD1.AseConnection.messageBox("Guardado Exitosamente.");
                txtParamMod.Text = "";
                txtNumPres.Text = "";
                txtNumPres.Enabled = false;
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

            cmd.CommandText = "execute SP_READ_PAGOS @id =" + txtParamBuscar.Text;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
            x = Convert.ToInt32(dt.Rows.Count.ToString());
            if (x == 0)
                TBD1.AseConnection.messageBox("Registro No Existe.");
            else
            {
                dt.Columns["numero_pago"].ColumnName = "Numero Pago";
                dt.Columns["fecha"].ColumnName = "Fecha";
                dt.Columns["capital"].ColumnName = "Capital";
                dt.Columns["intereses"].ColumnName = "Intereses";
                dt.Columns["monto"].ColumnName = "Monto";
                dt.Columns["prestamos_numero_prestamo"].ColumnName = "Numero Prestamo";
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
            cmd.CommandText = "execute SP_READ_PAGOS2 @id =" + txtParamEliminar.Text + ",@num_pres = " + txtParamEliminar2.Text;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);
            x = Convert.ToInt32(dt.Rows.Count.ToString());
            if (x == 1)
            {
                TBD1.AseConnection.messageBox("Registro Eliminado Exitosamente!");
                cmd.CommandText = "execute SP_Delete_Pagos @id =" + txtParamEliminar.Text + ",@prestamo = " + txtParamEliminar2.Text;
                cmd.ExecuteNonQuery();
                txtParamEliminar.Text = "";
                txtParamEliminar2.Text = "";
            }
            else
                TBD1.AseConnection.messageBox("Registro no Existe!");

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmAdmin admin = new FrmAdmin();
            admin.lblUser.Text = lblUser.Text;
            this.Hide();
            admin.Closed += (s, args) => this.Close();
            admin.Show();
        }

        private void FrmPago_Load(object sender, EventArgs e)
        {

        }
    } 
}
