﻿using System;
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
    public partial class frmMenuSoporte : Form
    {
        public frmMenuSoporte()
        {
            InitializeComponent();
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
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            OpenFRM_A(new frmMenuSoporteConsultas());
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            //controles y reportes
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            //controles y reportes
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Controles.lang == 1)
            {
                btnConfiguracion.Text = EN.Configuracion;
                btnPerfil.Text = EN.Perfil;
                btnConsultas.Text = EN.consultas;

            }
            else if (Controles.lang == 0)
            {
                btnConfiguracion.Text = "Configuracion";
                btnConsultas.Text = "Consultas";
                btnPerfil.Text = "Perfil";

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

        private void frmMenuSoporte_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
