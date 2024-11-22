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
using IDIOMA;

namespace BusConnectV2
{
    public partial class frmMenuUsuarioAvisos : Form
    {
        public frmMenuUsuarioAvisos()
        {
            InitializeComponent();
        }

        Usuarios objuser = new Usuarios();
        N_Users objnuser = new N_Users();

        private void frmMenuUsuarioAvisos_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = objnuser.N_GetSuscripciones(zDatos.ID);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "linea";

            if (Controles.lang == 1)
            {
                label1.Text = EN.Avisos_vigentes;
                label2.Text = EN.Avisos_vencidos;
                label3.Text = EN.Linea;

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int linea = int.Parse(comboBox1.Text);
                DataTable dtVigentes = new DataTable();
                dtVigentes = objnuser.n_getavisos(linea);
                dataGridViewVigentes.DataSource = dtVigentes;
                DataTable dtVencidos = new DataTable();
                dtVencidos = objnuser.n_getavisosVencidos(linea);
                dataGridViewVencidos.DataSource = dtVencidos;
            }
            catch (Exception)
            {

                int a;    //esto esta aca porque si no tiraba error, como el juego ese que sin la textura random del coco no funcionaba, int a es nuestro coco
            }
        }
    }
}
