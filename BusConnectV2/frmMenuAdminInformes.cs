using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusConnectV2
{
    public partial class frmMenuAdminInformes : Form
    {
        //TODO ESTE FORMULARIO ES DE REPORTES
        public frmMenuAdminInformes()
        {
            InitializeComponent();
        }

        private void frmMenuAdminInformes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSInformeUsuarios.Usuarios' Puede moverla o quitarla según sea necesario.
            this.UsuariosTableAdapter.Fill(this.DSInformeUsuarios.Usuarios);
            // TODO: esta línea de código carga datos en la tabla 'dSInformeAvisos.Avisos' Puede moverla o quitarla según sea necesario.
            this.avisosTableAdapter.Fill(this.dSInformeAvisos.Avisos);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
