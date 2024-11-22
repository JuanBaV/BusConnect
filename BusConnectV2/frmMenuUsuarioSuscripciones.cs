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
    public partial class frmMenuUsuarioSuscripciones : Form
    {
        public frmMenuUsuarioSuscripciones()
        {
            InitializeComponent();
        }

        N_Users objnuser = new N_Users();
        private void buttonSuscribirse_Click(object sender, EventArgs e)
        {
            if (comboBoxLineas.Text == "")
            {
                MessageBox.Show("Seleccionar una linea a la que suscribirse");
            }
            else
            {
                int i = objnuser.N_SuscribirseLinea(zDatos.coduser, int.Parse(comboBoxLineas.Text));
                if (i == 1)
                {
                    MessageBox.Show("suscripcion realizada con exito");
                }
                else
                {
                    MessageBox.Show("Error al suscribirse");
                }
            }
        }

        private void frmMenuUsuarioSuscripciones_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = objnuser.N_GetLineas();
            comboBoxLineas.DataSource = dt;
            comboBoxLineas.DisplayMember = "CodLinea";
        }
    }
}
