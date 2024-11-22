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
using BLL;
using Negocio;
using IDIOMA;
using System.IO;

namespace BusConnectV2
{
    public partial class frmMenuAdminRegEmp : Form
    {
        public frmMenuAdminRegEmp()
        {
            InitializeComponent();
        }

        Usuarios objuser = new Usuarios();
        N_Users objnuser = new N_Users();

        private void frmMenuAdminRegEmp_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            cargaeEMP();
            if (Controles.lang == 1)
            {
                comboBox1.Text = EN.NOMBRE;
                textBoxPass.Text = EN.Contraseña;
                textBoxPassCONFIRM.Text = EN.Confirmar_contraseña;
                buttonRegistrar.Text = EN.Registrarse;
                buttonEliminar.Text = EN.Eliminar;
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

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        void eliminar()
        {
            if (comboBox1.Text == "                  NOMBRE")
            {
                MessageBox.Show("Proveer un nombre de empresa para eliminar");
            }
            else
            {
                objuser.ID = comboBox1.Text;
                int i = objnuser.N_EMPDelete(objuser);
                //aca va 2 y no uno porque se ejecutan 2 comandos en el procedimiento almacenado
                //eliminar de la tabla usuario y de la de empresas
                if (i == 2)
                {
                    MessageBox.Show("Empresa eliminada con exito");
                    cargaeEMP();
                }
                else
                {
                    MessageBox.Show("Empresa no encontrada");
                }
            }
        }
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "                  NOMBRE" || textBoxPass.Text == "CONTRASEÑA" || textBoxPassCONFIRM.Text == "CONFIRMAR CONTRASEÑA")
            {
                MessageBox.Show("Completar todos los campos");
            }
            else
            {
                if (textBoxPass.Text == textBoxPassCONFIRM.Text)
                {
                    objuser.ID = comboBox1.Text;
                    objuser.Contraseña = textBoxPass.Text;
                    objuser.Role = 3;
                    int i = objnuser.N_EMPregister(objuser);
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    int a = objnuser.N_register(objuser, ms.GetBuffer());
                    if (i == 1 && a == 1)
                    {
                        MessageBox.Show("Empresa registrada correctamente");
                        cargaeEMP();
                    }
                    else
                    {
                        MessageBox.Show("Nombre no disponible");
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
        }

        void cargaeEMP()
        {
            DataTable dt = new DataTable();
            dt = objnuser.N_GetEmpresas();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "NombreEMP";

            if (Controles.lang == 1)
            {
                comboBox1.Text = EN.NOMBRE;
                textBoxPass.Text = EN.Contraseña;
                textBoxPassCONFIRM.Text = EN.Confirmar_contraseña;

            }
            else
            {
                comboBox1.Text = "                  NOMBRE";
                textBoxPass.Text = "CONTRASEÑA";
                textBoxPassCONFIRM.Text = "CONFIRMAR CONTRASEÑA";
            }
            textBoxPassCONFIRM.UseSystemPasswordChar = false;
            textBoxPass.UseSystemPasswordChar = false;
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            comboBox1.Text = "";
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            string user = comboBox1.Text;
            if (user.Equals("                  NOMBRE"))
            {
                comboBox1.Text = "                  NOMBRE";
            }
            else
            {
                if (user.Equals(""))
                {
                    if (Controles.lang == 1)
                    {
                        comboBox1.Text = EN.NOMBRE;


                    }
                    else
                    {
                        comboBox1.Text = "                  NOMBRE";

                    }

                }
                else
                {
                    comboBox1.Text = user;
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
                    if (Controles.lang == 1)
                    {

                        textBoxPassCONFIRM.Text = EN.Confirmar_contraseña;

                    }
                    else
                    {

                        textBoxPassCONFIRM.Text = "CONFIRMAR CONTRASEÑA";
                    }

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
                    if (Controles.lang == 1)
                    {

                        textBoxPass.Text = EN.Contraseña;


                    }
                    else
                    {

                        textBoxPass.Text = "CONTRASEÑA";

                    }

                    textBoxPass.UseSystemPasswordChar = false;
                }
                else
                {
                    textBoxPass.Text = user;
                }
            }
        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            textBoxPass.Text = "";
            textBoxPass.UseSystemPasswordChar = true;
        }
    }
}
