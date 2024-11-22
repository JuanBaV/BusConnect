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
    public partial class editarUsers : Form
    {


        //TODO ESTE FORMULARIO ES EN MODO DESCONECTADO

        public editarUsers()
        {
            InitializeComponent();
        }
        N_Users users = new N_Users();
        Usuarios usersobj = new Usuarios();
        DataSet Ds = new DataSet();
        private void editarUsers_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            //var watcher = new FileSystemWatcher(@"C:\Users\Juan\Desktop\Programacion\LUG\BusConnectV2\BusConnectV2\BusConnectV2\BusConnectV2\BusConnectV2\bin\Debug");
            var watcher = new FileSystemWatcher(@"C:");          //fileSystemwatcher
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

            watcher.Filter = "ArchivoUsuarios.xml";
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
            MessageBox.Show($"Renamed:" + Environment.NewLine+    $"Old: {e.OldFullPath}" +Environment.NewLine + $"    New: {e.FullPath}" );
            
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



        //void grid()
        //{
        //    DataTable dt = new DataTable();
        //    dt = users.N_getusers();
        //    dataGridView1.DataSource = dt;
        //    dataGridView1.ReadOnly = false;
        //    dataGridView1.Columns["Cod_usuario"].ReadOnly = true;
        //    dataGridView1.Columns["Role"].ReadOnly = true;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    usersobj.cod = (int)row.Cells["Cod_usuario"].Value;
            //    usersobj.ID = Convert.ToString(row.Cells["ID"].Value);
            //    usersobj.Contraseña = Convert.ToString(row.Cells["Password"].Value);
            //    usersobj.imagen = (byte[])row.Cells["imagen"].Value;




            //    int i = users.N_editUser(usersobj);
            //}
            N_Users obje = new N_Users();
            obje.Agregar(Ds);
            CargarGrilla();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                OpenFileDialog fo = new OpenFileDialog();
                DialogResult dialogResult = fo.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    dataGridView1.CurrentCell.Value = Image.FromFile(fo.FileName);
 

                }
            }
        }

        //XML Y DATASET
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    XmlSerializer ser = new XmlSerializer(typeof(DataSet));
        //    DataSet ds1 = new DataSet("myDataSet");
        //    DataTable dt = new DataTable();
        //    dt = users.N_getusers();
        //    ds1.Tables.Add(dt);
        //    TextWriter writer = new StreamWriter("ArchivoUsuarios.xml");
        //    ser.Serialize(writer, ds1);
        //    writer.Close();
        //    MessageBox.Show("Se creo el archivo");


        //}


        //XML Y DATASET
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            XmlSerializer ser = new XmlSerializer(typeof(DataSet));
            DataSet ds1 = new DataSet("myDataSet");

            using (FileStream fs = new FileStream("ArchivoUsuarios.xml", FileMode.Open, FileAccess.Read))
            {
                ds1 = ser.Deserialize(fs) as DataSet;
            }
            DataTable dt = ds1.Tables[0];
            dataGridView1.DataSource = dt;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ds.RejectChanges();
        }

        public void CargarGrilla()
        {
            dataGridView1.DataSource = null;
            N_Users obje = new N_Users();
            Ds = obje.Cargar();
            dataGridView1.DataSource = Ds.Tables[0];
        }
    }
}
