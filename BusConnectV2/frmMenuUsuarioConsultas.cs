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
    public partial class frmMenuUsuarioConsultas : Form
    {
        public frmMenuUsuarioConsultas()
        {
            InitializeComponent();
        }

        N_Users objnuser = new N_Users();

        private void frmMenuUsuarioConsultas_Load(object sender, EventArgs e)
        {
            getConsultas();
            if (Controles.lang == 1)
            {
                labelMConsultas.Text = EN.mis_consultas;

                labelNroConsulta.Text = EN.NroConsulta;
                buttonEnviarConsulta.Text = EN.Enviar;
                labelRespuesta.Text = EN.Respuesta;
                labelCosnulta.Text = EN.Escribir_consulta;
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

        private void buttonEnviarConsulta_Click(object sender, EventArgs e)
        {
            if (richTextBoxConsulta.Text != "")
            {
                int i = objnuser.N_registrar_consulta(richTextBoxConsulta.Text, zDatos.coduser);
                if (i == 1)
                {
                    MessageBox.Show("Consulta realizada con exito");
                    getConsultas();
                }
                else
                {
                    MessageBox.Show("Error al realizar la consulta");
                }
            }
            else
            {
                MessageBox.Show("No se puede enviar una consulta vacia");
            }
        }

        void getConsultas()
        {
            DataTable dt = new DataTable();
            dt = objnuser.N_ConsultasUser(zDatos.coduser);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            richTextBox1.Text = selectedRow.Cells[3].Value.ToString();
        }
    }
}
