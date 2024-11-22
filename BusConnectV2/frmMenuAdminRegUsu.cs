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
using BLL;
using Negocio;
using IDIOMA;
using System.IO;

namespace BusConnectV2
{
    public partial class frmMenuAdminRegUsu : Form
    {
        public frmMenuAdminRegUsu()
        {
            InitializeComponent();
        }

        Usuarios objuser = new Usuarios();
        N_Users objnuser = new N_Users();
        void reg()
        {
            if (textBoxID.Text == "USUARIO" || textBoxPass.Text == "CONTRASEÑA" || textBoxPassCONFIRM.Text == "CONFIRMAR CONTRASEÑA")
            {
                MessageBox.Show("Completar todos los campos");
            }
            else
            {
                if (textBoxPass.Text == textBoxPassCONFIRM.Text)
                {
                    objuser.ID = textBoxID.Text;
                    objuser.Contraseña = textBoxPass.Text;
                    objuser.Role = cmbRol.SelectedIndex + 1;
                    MemoryStream ms = new MemoryStream();
                    pictureBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    int i = objnuser.N_register(objuser, ms.GetBuffer());


                    if (i == 1)
                    {
                        MessageBox.Show("Usuario registrado correctamente");

                    }
                    else
                    {
                        MessageBox.Show("ID no disponible");
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }

            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            reg();
        }

        private void textBoxID_Enter(object sender, EventArgs e)
        {
            textBoxID.Text = "";
        }

        private void textBoxID_Leave(object sender, EventArgs e)
        {
            string user = textBoxID.Text;
            if (user.Equals("USUARIO"))
            {
                textBoxID.Text = "USUARIO";

            }
            else
            {
                if (user.Equals(""))
                {
                    textBoxID.Text = "USUARIO";


                }
                else
                {
                    textBoxID.Text = user;

                }
            }
        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            textBoxPass.Text = "";

            textBoxPass.UseSystemPasswordChar = true;
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            string user = textBoxPass.Text;
            if (user.Equals("CONTRASEÑA"))
            {
                textBoxPass.Text = "CONTRASEÑA";


            }
            else
            {
                if (user.Equals(""))
                {
                    textBoxPass.Text = "CONTRASEÑA";

                    textBoxPass.UseSystemPasswordChar = false;

                }
                else
                {
                    textBoxPass.Text = user;

                }
            }
        }

        private void textBoxPassCONFIRM_Enter(object sender, EventArgs e)
        {
            textBoxPassCONFIRM.Text = "";

            textBoxPassCONFIRM.UseSystemPasswordChar = true;
        }

        private void textBoxPassCONFIRM_Leave(object sender, EventArgs e)
        {
            string user = textBoxPassCONFIRM.Text;
            if (user.Equals("CONTRASEÑA"))
            {
                textBoxPassCONFIRM.Text = "CONTRASEÑA";


            }
            else
            {
                if (user.Equals(""))
                {
                    textBoxPassCONFIRM.Text = "CONTRASEÑA";

                    textBoxPassCONFIRM.UseSystemPasswordChar = false;

                }
                else
                {
                    textBoxPassCONFIRM.Text = user;

                }
            }
        }

        private void frmMenuAdminRegUsu_Load(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            if (Controles.lang == 1)
            {
                textBoxID.Text = EN.Usuario;
                textBoxPass.Text = EN.Contraseña;
                textBoxPassCONFIRM.Text = EN.Confirmar_contraseña;
                //buttonRegistrar.Text = EN.Registrarse;
                label5.Text = EN.Rol;
            }
            if (Controles.oscuro == 1)
            {
                this.BackColor = Color.FromArgb(64, 64, 64);
                foreach (Control control in this.Controls)
                {
                    if (control is Label)
                    {


                    }
                    else
                    {
                        control.BackColor = Color.Gray;

                    }

                }
            }
        }
    }
}
