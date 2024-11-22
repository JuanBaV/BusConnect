using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Negocio;
using BLL;

namespace BusConnectV2
{
    public partial class frmLogin : Form
    {
        Usuarios objuser = new Usuarios();
        N_Users objnuser = new N_Users();
        public static string usuario_id;

        public static string usuario_rol;



        void logueo()
        {
            DataTable dt = new DataTable();
            objuser.ID = txtUsuario.Text;
            objuser.Contraseña = txtContraseña.Text;
            zDatos.ID = txtUsuario.Text;


            dt = objnuser.N_user(objuser);


            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + dt.Rows[0][1].ToString());
                usuario_rol = dt.Rows[0][0].ToString();
                usuario_id = dt.Rows[0][1].ToString();
                zDatos.rol = int.Parse(usuario_rol);



                if (usuario_rol == "0")
                {
                    frmMenuAdmin frm = new frmMenuAdmin();
                    frm.Show();
                    this.Hide();
                }
                else if (usuario_rol == "1")
                {
                    frmMenuSoporte frm = new frmMenuSoporte();
                    frm.Show();
                    this.Hide();
                }
                else if (usuario_rol == "2")
                {
                    frmMenuUsuario frm = new frmMenuUsuario();
                    frm.Show();
                    this.Hide();
                }
                else if (usuario_rol == "3")
                {
                    DataTable dt2 = new DataTable();
                    dt2 = objnuser.N_getCodEmpresa(objuser);
                    if (dt.Rows.Count > 0)
                    {
                        zDatos.codEmpresa = (int)dt2.Rows[0][0];
                    }
                    frmMenuEmpresa frm = new frmMenuEmpresa();
                    frm.Show();
                    this.Hide();
                }


            }
            else
            {
                MessageBox.Show("El ID o la contraseña son incorrectos");
            }



        }

        public frmLogin()
        {
            InitializeComponent();
        }




        private void label5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            logueo();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmLoginRegistro frm = new frmLoginRegistro();
            frm.Show();
            this.Hide();
        }

        private void txtUsuario_Enter_1(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
        }

        private void txtUsuario_Leave_1(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            if (user.Equals("USUARIO"))
            {
                txtUsuario.Text = "USUARIO";

            }
            else
            {
                if (user.Equals(""))
                {
                    txtUsuario.Text = "USUARIO";


                }
                else
                {
                    txtUsuario.Text = user;

                }
            }
        }

        private void txtContraseña_Enter_1(object sender, EventArgs e)
        {
            txtContraseña.Text = "";

            txtContraseña.UseSystemPasswordChar = true;
        }

        private void txtContraseña_Leave_1(object sender, EventArgs e)
        {
            string user = txtContraseña.Text;
            if (user.Equals("CONTRASEÑA"))
            {
                txtContraseña.Text = "CONTRASEÑA";


            }
            else
            {
                if (user.Equals(""))
                {
                    txtContraseña.Text = "CONTRASEÑA";

                    txtContraseña.UseSystemPasswordChar = false;

                }
                else
                {
                    txtContraseña.Text = user;

                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
