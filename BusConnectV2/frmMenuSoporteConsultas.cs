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

namespace BusConnectV2
{
    public partial class frmMenuSoporteConsultas : Form
    {
        public frmMenuSoporteConsultas()
        {
            InitializeComponent();
        }

        N_Users objnuser = new N_Users();

        void getConsultas()
        {
            DataTable dt = new DataTable();
            dt = objnuser.N_GetConsultas();
            dataGridView1.DataSource = dt;
        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || richTextBox1.Text == "")
            {
                MessageBox.Show("Completar todos los campos");
            }
            else
            {


                int i = objnuser.N_ResponderConsulta(int.Parse(textBox1.Text), richTextBox1.Text);
                if (i == 1)
                {
                    MessageBox.Show("Consulta respondida con exito");
                    getConsultas();
                }
                else
                {
                    MessageBox.Show("Error al responder la consulta");
                }
            }
        }

        private void frmMenuSoporteConsultas_Load(object sender, EventArgs e)
        {
            getConsultas();

            if (Controles.lang == 1)
            {
                label1.Text = EN.NroConsulta;
                label2.Text = EN.Respuesta;
                buttonEnviar.Text = EN.Enviar;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
        }
    }
}
