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
    public partial class Configuracion : UserControl
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            if (Controles.oscuro == 1)
            {
                rjToggleButton1.Checked = true;
            }
            if (Controles.lang == 1)
            {
                cmbIdioma.SelectedIndex = 0;
                label1.Text = EN.Idioma;
                label2.Text = EN.Modo_oscuro;
            }
            else
            {
                cmbIdioma.SelectedIndex = 1;
                label1.Text = "Idioma";
                label2.Text = "Modo oscuro";
            }
        }

        private void rjToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rjToggleButton1.Checked == true)
            {
                Controles.oscuro = 1;
                this.BackColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                Controles.oscuro = 0;
                this.BackColor = Color.White;
            }
        }

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIdioma.Text == "English")
            {
                Controles.lang = 1;
            }
            else if (cmbIdioma.Text == "Español")
            {
                Controles.lang = 0;
            }
            if (Controles.lang == 1)
            {
                label1.Text = EN.Idioma;
                label2.Text = EN.Modo_oscuro;
            }
            else
            {
                label1.Text = "Idioma";
                label2.Text = "Modo oscuro";
            }
        }
    }
}
