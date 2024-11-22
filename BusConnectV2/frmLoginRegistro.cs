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
using Negocio;
using BLL;
using System.IO;
using IDIOMA;
using System.Text.RegularExpressions;

namespace BusConnectV2
{
    public partial class frmLoginRegistro : Form
    {
        public frmLoginRegistro()
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
                    //EXPRESIONES REGULARES
                    Regex re = new Regex(@"\d");

                    if (!re.IsMatch(this.textBoxPass.Text))
                    {
                        MessageBox.Show("Lo lamento, su contraseña debe poseer almenos un numero");
                    }
                    else
                    {
                        objuser.ID = textBoxID.Text;
                        objuser.Contraseña = textBoxPass.Text;
                        objuser.Role = 2;
                        MemoryStream ms = new MemoryStream();
                        pictureBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        int i = objnuser.N_register(objuser, ms.GetBuffer());

                        if (i == 1)
                        {
                            MessageBox.Show("Usuario registrado correctamente");
                            frmLogin frm = new frmLogin();
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("ID no disponible");
                        }


                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            reg();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void textBoxPassCONFIRM_Enter(object sender, EventArgs e)
        {
            textBoxPassCONFIRM.Text = "";

            textBoxPassCONFIRM.UseSystemPasswordChar = true;
        }

        private void frmLoginRegistro_Load(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            if (Controles.lang == 1)
            {
                textBoxID.Text = EN.Usuario;
                textBoxPass.Text = EN.Contraseña;
                textBoxPassCONFIRM.Text = EN.Confirmar_contraseña;
                btnRegistrar.Text = EN.Registrarse;
                btnVolver.Text = EN.Volver;
            }
        }
    }
}
