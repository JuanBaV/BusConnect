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
using System.Globalization;

namespace BusConnectV2
{
    public partial class frmMenuEmpresaAvisos : Form
    {
        public frmMenuEmpresaAvisos()
        {
            InitializeComponent();
        }

        Avisos aviso = new Avisos();
        N_Users objnuser = new N_Users();

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            reg();
        }

        private void textBoxTitulo_Enter(object sender, EventArgs e)
        {
            textBoxTitulo.Text = "";
        }

        private void textBoxTitulo_Leave(object sender, EventArgs e)
        {
            string user = textBoxTitulo.Text;
            if (user.Equals("TITULO"))
            {
                textBoxTitulo.Text = "TITULO";

            }
            else
            {
                if (user.Equals(""))
                {
                    textBoxTitulo.Text = "TITULO";


                }
                else
                {
                    textBoxTitulo.Text = user;

                }
            }
        }

        private void richTextBoxDescrip_Enter(object sender, EventArgs e)
        {
            richTextBoxDescrip.Text = "";
        }

        private void richTextBoxDescrip_Leave(object sender, EventArgs e)
        {
            string user = richTextBoxDescrip.Text;
            if (user.Equals("DESCRIPCION"))
            {
                richTextBoxDescrip.Text = "DESCRIPCION";

            }
            else
            {
                if (user.Equals(""))
                {
                    richTextBoxDescrip.Text = "DESCRIPCION";


                }
                else
                {
                    richTextBoxDescrip.Text = user;

                }
            }
        }

        void reg()
        {
            if (richTextBoxDescrip.Text == "DESCRIPCION" && textBoxTitulo.Text == "TITULO")
            {
                MessageBox.Show("Completar todos los campos");
            }
            else
            {
                aviso.titulo = textBoxTitulo.Text;
                aviso.descripcion = richTextBoxDescrip.Text;
                aviso.inicio = dateTimePicker1.Value;
                aviso.fin = dateTimePicker2.Value;
                aviso.linea = int.Parse(comboBox1.Text);
                int i = objnuser.N_AvisoRegister(aviso);


                if (i == 1)
                {
                    MessageBox.Show("Aviso registrado correctamente");

                }
                else
                {
                    MessageBox.Show("Error al registrar el aviso");
                }
            }

        }

        private void frmMenuEmpresaAvisos_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = objnuser.N_GetLineasemp(zDatos.codEmpresa);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "CodLinea";


            if (Controles.lang == 1)
            {

                textBoxTitulo.Text = EN.Titulo;
                richTextBoxDescrip.Text = EN.Descripcion;
                label2.Text = EN.Inicio;
                label3.Text = EN.Fin;
                buttonRegistrar.Text = EN.Registrarse;




            }
            //else if (Controles.lang == 0)
            //{
            //    comboBox1.Text = "Ramal";
            //    comboBoxID.Text = "N° linea";
            //    buttonEliminar.Text = "Eliminar";
            //    buttonEliminarRamal.Text = "Eliminar";
            //    buttonRegistrar.Text = "Registrar";
            //    buttonRegistrarRamal.Text = "Registrar";

            //}
            if (Controles.oscuro == 1)
            {
                label2.ForeColor = Color.Gray;
                label3.ForeColor = Color.Gray;
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
            else if (Controles.oscuro != 1)
            {
                this.BackColor = Color.White;
                foreach (Control control in this.Controls)
                {
                    if (control is Label)
                    {


                    }
                    else
                    {
                        control.BackColor = Color.PowderBlue;

                    }

                }
            }
        }
    }
}
