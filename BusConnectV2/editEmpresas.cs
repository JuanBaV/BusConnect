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
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace BusConnectV2
{
    public partial class editEmpresas : Form
    {
        //TODO ESTE FORMULARIO ES EN MODO DESCONECTADO
        public editEmpresas()
        {
            InitializeComponent();
        }
        N_Users users = new N_Users();
        Usuarios usersobj = new Usuarios();
        private void editEmpresas_Load(object sender, EventArgs e)
        {
            //FileSystemwatcher
            grid();
            //var watcher = new FileSystemWatcher(@"C:\Users\Juan\Desktop\Programacion\LUG\BusConnectV2\BusConnectV2\BusConnectV2\BusConnectV2\BusConnectV2\bin\Debug");
            var watcher = new FileSystemWatcher(@"C:");
            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher.Changed += OnChanged;
            watcher.Created += OnCreated;
            watcher.Deleted += OnDeleted;
            watcher.Renamed += OnRenamed;
            watcher.Error += OnError;

            watcher.Filter = "ArchivoEmpresas.xml";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
        }

        private static void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            MessageBox.Show($"Changed: {e.FullPath}");

        }

        private static void OnCreated(object sender, FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}";
            MessageBox.Show(value);
        }

        private static void OnDeleted(object sender, FileSystemEventArgs e) =>
            MessageBox.Show($"Deleted: {e.FullPath}");

        private static void OnRenamed(object sender, RenamedEventArgs e)
        {
            MessageBox.Show($"Renamed:" + Environment.NewLine + $"Old: {e.OldFullPath}" + Environment.NewLine + $"    New: {e.FullPath}");

        }

        private static void OnError(object sender, ErrorEventArgs e) =>
            PrintException(e.GetException());

        private static void PrintException(Exception ex)
        {
            if (ex != null)
            {
                MessageBox.Show($"Message: {ex.Message}" + Environment.NewLine + "Stacktrace:" + ex.StackTrace);
                PrintException(ex.InnerException);
            }
        }
        void grid()
        {
            DataTable dt = new DataTable();
            dt = users.N_GetEmpresas();
            dataGridView1.DataSource = dt;
            dataGridView1.ReadOnly = false;
            dataGridView1.Columns["CodEmp"].ReadOnly = true;
            dataGridView1.Columns["codUsuario"].ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                usersobj.cod = (int)row.Cells["codUsuario"].Value;
                usersobj.ID = Convert.ToString(row.Cells["NombreEmp"].Value);
                usersobj.Contraseña = Convert.ToString(row.Cells["PasswordEmp"].Value);
                usersobj.imagen = null;




                int i = users.editUserNF(usersobj);
                int a=users.editEmp(usersobj);
            }
        }

        //XML Y DATASET
        private void button2_Click(object sender, EventArgs e)
        {
            XmlSerializer ser = new XmlSerializer(typeof(DataSet));
            DataSet ds = new DataSet("myDataSet");
            DataTable dt = new DataTable();
            dt = users.N_GetEmpresas();
            ds.Tables.Add(dt);
            TextWriter writer = new StreamWriter("ArchivoEmpresas.xml");
            ser.Serialize(writer, ds);
            writer.Close();
            MessageBox.Show("Se creo el archivo");
        }

        //XML Y DATASET
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            XmlSerializer ser = new XmlSerializer(typeof(DataSet));
            DataSet ds = new DataSet("myDataSet");

            using (FileStream fs = new FileStream("ArchivoEmpresas.xml", FileMode.Open, FileAccess.Read))
            {
                ds = ser.Deserialize(fs) as DataSet;
            }
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
        }
    }
}
