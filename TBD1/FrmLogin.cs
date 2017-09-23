using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace TBD1
{
   
    public partial class frmLogin : Form
    {


        public frmLogin()
        {
            InitializeComponent();
            txtContra.PasswordChar = '*';
        }

        
        private static OdbcConnection Connect()
        {
            OdbcConnection con = null;
            string conString = "Dsn=Sybase2;uid=sa;pwd=BorisGarcia17";
            con = new OdbcConnection(conString);
            con.Open();
            return con;
        }

        private static void Close(OdbcConnection con)
        {
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbIniciar.DisplayMember = "Text";
            cmbIniciar.ValueMember = "Value";
            cmbIniciar.Items.Add(new { Text = "Afiliado", Value = "Afiliado" });
            cmbIniciar.Items.Add(new { Text = "Administrador", Value = "Administrador" });
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            int x = 0;
            int i = 0;
         
            OdbcConnection con = Connect();
            OdbcCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
           
            cmd.CommandText = "execute SP_READ_USUARIO @username ='"+txtUser.Text+"',@contra ='"+txtContra.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());
            
            if (i != 0)
            {
                if(cmbIniciar.Text == "Afiliado")
                {
                    cmd.CommandText = "execute SP_READ_USUARIO_ROL @user='" + txtUser.Text + "',@contra='" + txtContra.Text + "'"+",@rol = 'Afiliado'";
                    cmd.ExecuteNonQuery();
                    DataTable dt2 = new DataTable();
                    OdbcDataAdapter da2 = new OdbcDataAdapter(cmd);
                    da.Fill(dt2);
                    x = Convert.ToInt32(dt2.Rows.Count.ToString());

                    if (x != 0)
                    {

                        this.Hide();
                        FrmAfiliado f2 = new FrmAfiliado();
                        f2.lblUser.Text = txtUser.Text;
                        f2.Closed += (s, args) => this.Close();
                        f2.Show();
                    }
                    else
                       TBD1.AseConnection.messageBox("Su usuario no posee el rol seleccionado.");

                }
                else if (cmbIniciar.Text == "Administrador")
                {
                    
                    cmd.CommandText = "execute SP_READ_USUARIO_ROL @user='" + txtUser.Text + "',@contra='" + txtContra.Text + "'" + ",@rol = 'Administrador'";
                    cmd.ExecuteNonQuery();
                    DataTable dt2 = new DataTable();
                    OdbcDataAdapter da2 = new OdbcDataAdapter(cmd);
                    da.Fill(dt2);

                    x = Convert.ToInt32(dt2.Rows.Count.ToString());

                    if (x != 0)
                    {
                        this.Hide();
                        FrmAdmin f3 = new FrmAdmin();
                        f3.lblUser.Text = txtUser.Text;
                        f3.Closed += (s, args) => this.Close();
                        f3.Show();
                    }
                    else
                        TBD1.AseConnection.messageBox("Su usuario no posee el rol seleccionado.");
                }
                
            }
            else if (i == 0)
                TBD1.AseConnection.messageBox("Su usuario o contraseña no es correcta.");
            
            /*
            //Temporal
            this.Hide();
            FrmAfiliado f3 = new FrmAfiliado();
            f3.lblUser.Text = "Admin";
            f3.Closed += (s, args) => this.Close();
            f3.Show();
            */
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {           
            this.Close();            
        }
    }
}
