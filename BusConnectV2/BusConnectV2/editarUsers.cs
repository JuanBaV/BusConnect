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

namespace BusConnectV2
{
    public partial class editarUsers : Form
    {
        public editarUsers()
        {
            InitializeComponent();
        }
        N_Users users = new N_Users();
        Usuarios usersobj = new Usuarios();
        private void editarUsers_Load(object sender, EventArgs e)
        {
            grid();
        }

        void grid()
        {
            DataTable dt = new DataTable();
            dt=users.N_getusers();
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                usersobj.ID = Convert.ToString(row.Cells["ID"].Value);
                usersobj.Contraseña = Convert.ToString(row.Cells["Password"].Value);
                int i = users.N_editUser(usersobj);
            }
        }
    }
}
