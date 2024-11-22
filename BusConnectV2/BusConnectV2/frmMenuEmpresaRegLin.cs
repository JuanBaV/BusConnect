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
using BLL;
using Negocio;

namespace BusConnectV2
{
    public partial class frmMenuEmpresaRegLin : Form
    {
        public frmMenuEmpresaRegLin()
        {
            InitializeComponent();
        }

        Linea linea = new Linea();
        Ramales ramal = new Ramales();
        Colectivos colectivo = new Colectivos();
        N_Users objnuser = new N_Users();

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            linea.nro = int.Parse(comboBoxID.Text);
            linea.codEmpresa = zDatos.codEmpresa;
            int i = objnuser.N_addLinea(linea);
            if (i == 1)
            {
                MessageBox.Show("Linea registrada exitosamente");
            }
            else
            {
                MessageBox.Show("Error al registrar la linea");
            }
            DataTable dt = new DataTable();
            dt = objnuser.N_GetLineas();
            comboBoxID.DataSource = dt;
            comboBoxID.DisplayMember = "CodLinea";

            DataTable dt1 = new DataTable();
            dt1 = objnuser.N_GetLineas();
            comboBoxRamalLinea.DataSource = dt1;
            comboBoxRamalLinea.DisplayMember = "CodLinea";
        }

        private void frmMenuEmpresaRegLin_Load(object sender, EventArgs e)
        {

            if (Controles.lang == 1)
            {
                comboBoxRamal.Text = EN.Ramal;
                comboBoxID.Text = EN.nroLinea;
                buttonEliminar.Text = EN.Eliminar;
                buttonEliminarRamal.Text = EN.Eliminar;
                buttonRegistrar.Text = EN.Registrarse;
                buttonRegistrarRamal.Text = EN.Registrarse;


            }
            ////else if (Controles.lang == 0)
            ////{
            ////    comboBox1.Text = "Ramal";
            ////    comboBoxID.Text = "N° linea";
            ////    buttonEliminar.Text = "Eliminar";
            ////    buttonEliminarRamal.Text = "Eliminar";
            ////    buttonRegistrar.Text = "Registrar";
            ////    buttonRegistrarRamal.Text = "Registrar";

            ////}
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
            DataTable dt = new DataTable();
            dt = objnuser.N_GetLineas();
            comboBoxID.DataSource = dt;
            comboBoxID.DisplayMember = "CodLinea";

            DataTable dt1 = new DataTable();
            dt1 = objnuser.N_GetLineas();
            comboBoxRamalLinea.DataSource = dt1;
            comboBoxRamalLinea.DisplayMember = "CodLinea";
        }

        private void buttonRegistrarRamal_Click(object sender, EventArgs e)
        {
            frmMenuEmpresaRegRec RegRec = new frmMenuEmpresaRegRec();
            RegRec.textRamal.Text = comboBoxRamal.Text;
            ramal.codLinea = int.Parse(comboBoxRamalLinea.Text);
            ramal.codRamal = Convert.ToInt32(comboBoxRamal.Text);
            ramal.descripcion = richTextBox1.Text;
            int i = objnuser.N_addRamal(ramal);
            if (i == 1)
            {
                MessageBox.Show("Ramal registrado exitosamente");
                RegRec.Show();
            }
            else
            {
                MessageBox.Show("Error al registrar el ramal");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colectivo.Ramal = int.Parse(comboBoxCOLRAMAL.Text);
            colectivo.Modelo = textBoxMODELO.Text;
            colectivo.color = textBoxCOLOR.Text;
            int i = objnuser.N_addColectivo(colectivo);
            if (i == 1)
            {
                MessageBox.Show("Colectivo registrado exitosamente");
            }
            else
            {
                MessageBox.Show("Error al registrar el colectivo");
            }
        }

        private void comboBoxRamal_SelectedIndexChanged(object sender, EventArgs e)
        {
            int linea = int.Parse(comboBoxID.Text);
            DataTable dtRamales = new DataTable();
            dtRamales = objnuser.N_GetRamal(linea);
            comboBoxRamal.DataSource = dtRamales;
            comboBoxRamal.DisplayMember = "CodRamal";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //falta
        }

        private void buttonEliminarRamal_Click(object sender, EventArgs e)
        {
            //falta
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //falta
        }
    }
}
