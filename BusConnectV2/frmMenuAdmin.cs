using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDIOMA;

namespace BusConnectV2
{
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            panelPrinc.Controls.Clear();
            OpenFRM_A(new frmMenuAdminRegUsu());
        }

        private void frmMenuAdmin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private Form ActualForm;

        private void OpenFRM_A(Form FRM_A)
        {
            if (ActualForm != null)
            {
                ActualForm.Close();
            }
            ActualForm = FRM_A;
            FRM_A.TopLevel = false;
            FRM_A.FormBorderStyle = FormBorderStyle.None;
            FRM_A.Dock = DockStyle.Fill;
            panelPrinc.Controls.Add(FRM_A);
            panelPrinc.Tag = FRM_A;
            FRM_A.BringToFront();
            FRM_A.Show();

        }

        private void btnRegistrarEmpresa_Click(object sender, EventArgs e)
        {
            panelPrinc.Controls.Clear();
            OpenFRM_A(new frmMenuAdminRegEmp());
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            panelPrinc.Controls.Clear();
            OpenFRM_A(new editarUsers());
        }

        private void btnEditarEmpresa_Click(object sender, EventArgs e)
        {
            panelPrinc.Controls.Clear();
            OpenFRM_A(new editEmpresas());

        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            panelPrinc.Controls.Clear();
            OpenFRM_A(new frmMenuAdminInformes());
            //controles y reportes frm
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            UCConfiguracion X = new UCConfiguracion();
            panelPrinc.Controls.Clear();
            X.Dock = DockStyle.Fill;
            panelPrinc.Controls.Add(X);

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Controles.lang == 1)
            {
                btnConfiguracion.Text = EN.Configuracion;
                btnEditarEmpresa.Text = EN.editar_empresa;
                btnEditarUsuario.Text = EN.editar_usuario;
                btnInformes.Text = EN.informes;
                btnRegistrarEmpresa.Text = EN.Registrar_empresa;
                btnRegistrarUsuario.Text = EN.Registrar_usuario;

            }
            else if (Controles.lang == 0)
            {
                btnConfiguracion.Text = "Configuracion";
                btnEditarEmpresa.Text = "Editar Empresa";
                btnEditarUsuario.Text = "Editar usuario";
                btnInformes.Text = "Informes";
                btnRegistrarEmpresa.Text = "Registrar empresa";
                btnRegistrarUsuario.Text = "Registrar usuario";

            }
            if (Controles.oscuro == 1)
            {
                this.BackColor = Color.DarkGray;
                panel1.BackColor = Color.FromArgb(64, 64, 64); ;

                pictureBox1.Image = Image.FromFile("Logo oscuro.png");

                foreach (Control con in this.Controls)
                {
                    if (con is Button)
                    {
                        con.BackColor = Color.DarkGray;
                    }
                    else if (con is Label)
                    {
                        label4.BackColor = this.BackColor;
                    }
                }




            }
            else if (Controles.oscuro != 1)
            {
                this.BackColor = Color.PowderBlue;

                pictureBox1.Image = Image.FromFile("LOGO.png");
                foreach (Control con in this.Controls)
                {
                    if (con is Button)
                    {
                        con.BackColor = Color.White;
                    }
                    else if (con is Label)
                    {
                        label4.BackColor = this.BackColor;
                    }
                }


            }
        }

        private void panelPrinc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
