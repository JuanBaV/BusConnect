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
using IDIOMA;
using System.IO;

namespace BusConnectV2
{
    public partial class Perfil : UserControl
    {
        public Perfil()
        {
            InitializeComponent();
        }
        Usuarios objuser = new Usuarios ();
        N_Users objnuser = new N_Users();
        void imagen()
        {
            DataTable dt = new DataTable();
            dt = objnuser.N_getImagen(zDatos.ID);

            byte[] img = (byte[])dt.Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);

        }
        private void Perfil_Load(object sender, EventArgs e)
        {
            if (Controles.lang == 1)
            {
                textBox1.Text = EN.Contraseña;
                textBoxPass.Text = "New password";
                textBoxPassCONFIRM.Text = EN.Confirmar_contraseña;
                button1.Text = EN.Cambias_contraseña;
                button2.Text = EN.cambiar_imagen;
                buttonLogOut.Text = EN.Cerrar_sesion;

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
            imagen();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            if (Controles.lang == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        f.Hide();
                    }
                    frmLogin frm = new frmLogin();
                    frm.Show();
                }
                else
                {
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("¿Esta seguro que quiere cerrar la sesion?", "Cerrar sesion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        f.Hide();
                    }
                    frmLogin frm = new frmLogin();
                    frm.Show();
                }
                else
                {
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult dialogResult = fo.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(fo.FileName);
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                int i = objnuser.N_addImagen(ms.GetBuffer(), zDatos.ID);
                if (i == 1)
                {
                    MessageBox.Show("Imagen actualiuzada con exito");

                }
                else
                {
                    MessageBox.Show("Error al actualizar la imagen");
                }
            }
        }
    }
}
