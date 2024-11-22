using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Configuration;
using System.Data.SqlClient;
using BLL;
using Negocio;
using IDIOMA;
using System.IO;

namespace BusConnectV2
{
    public partial class frmMenuEmpresaRegRec : Form
    {
        public frmMenuEmpresaRegRec()
        {
            InitializeComponent();
        }

       
        RamalesUbi objramalesubi = new RamalesUbi();
        N_Users objnuser = new N_Users();

        public double a;
        public double b;
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        int filaseleccionada = 0;
        private void btnAgregarPunto_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txt_Descripcion.Text, txt_Latitud.Text, txt_Longitud.Text);
            PointLatLng spawn = new PointLatLng(Convert.ToDouble(txt_Latitud.Text), Convert.ToDouble(txt_Longitud.Text));
            marker = new GMarkerGoogle(spawn, GMarkerGoogleType.green);
            markerOverlay = new GMapOverlay("Marcador");
            markerOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(markerOverlay);
        }

        private void btnEliminarPunto_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(filaseleccionada);
        }

        private void btnGenerarRuta_Click(object sender, EventArgs e)
        {
            gMapControl1.Overlays.Clear();
            GMapOverlay Ruta = new GMapOverlay("Capa Ruta");
            List<PointLatLng> puntos = new List<PointLatLng>();
            double lat, lng;
            for (int filas = 0; filas < dataGridView1.Rows.Count - 1; filas++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[filas].Cells[1].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[filas].Cells[2].Value);
                puntos.Add(new PointLatLng(lat, lng));
                PointLatLng spawn = new PointLatLng(lat, lng);
                marker = new GMarkerGoogle(spawn, GMarkerGoogleType.green);
                markerOverlay = new GMapOverlay("Marcador");
                markerOverlay.Markers.Add(marker);
                gMapControl1.Overlays.Add(markerOverlay);
            }
            GMapRoute PuntosRuta = new GMapRoute(puntos, "Ruta");
            Ruta.Routes.Add(PuntosRuta);
            gMapControl1.Overlays.Add(Ruta);
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;

        }

        private void btnGuardarRuta_Click(object sender, EventArgs e)
        {
            
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    objramalesubi.CodRamal = Convert.ToInt32(textRamal.Text);
                    objramalesubi.Descripcion = Convert.ToString(row.Cells["Descripcion"].Value);
                    objramalesubi.Latitud = Convert.ToString(row.Cells["Lat"].Value);
                    objramalesubi.Longitud = Convert.ToString(row.Cells["Long"].Value);
                    int var = objnuser.N_Ubicaciones_register(objramalesubi);
                }
                this.Close();
                //if (var == 1)
                //{
                //    MessageBox.Show("Ruta guardada con exito");
                //    this.Close();
                //}
                //else
                //{
                //    MessageBox.Show("Error al guardar la ruta");
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error");
            }
        }

        private void frmMenuEmpresaRegRec_Load(object sender, EventArgs e)
        {
            if (Controles.lang == 1)
            {
                txt_Descripcion.Text = EN.Descripcion;
                txt_Latitud.Text = EN.latitud;
                txt_Longitud.Text = EN.longitud;
                //btnAgregar.Text = EN.agregar_punto;
                //btnEliminar.Text = EN.Eliminar;
                //btnGenerar.Text = EN.generar_ruta;




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
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Descripcion", typeof(string)));
            dt.Columns.Add(new DataColumn("Lat", typeof(double)));
            dt.Columns.Add(new DataColumn("Long", typeof(double)));

            dataGridView1.DataSource = dt;

            GeoCoordinateWatcher oWatcher = new GeoCoordinateWatcher();
            oWatcher.PositionChanged += (S, E) =>
            {
                var oCordinate = E.Position.Location;
                a = oCordinate.Latitude;
                b = oCordinate.Longitude;
                gMapControl1.DragButton = MouseButtons.Left;
                gMapControl1.CanDragMap = true;
                gMapControl1.MapProvider = GMapProviders.BingMap;
                gMapControl1.Position = new PointLatLng(oCordinate.Latitude, oCordinate.Longitude);
                gMapControl1.MinZoom = 0;
                gMapControl1.MaxZoom = 24;
                gMapControl1.Zoom = 14;
                gMapControl1.AutoScroll = true;
                PointLatLng spawn = new PointLatLng(a, b);
                marker = new GMarkerGoogle(spawn, GMarkerGoogleType.green);
                markerOverlay = new GMapOverlay("Marcador1");
                //markerOverlay.Markers.Add(marker);
                //gMapControl1.Overlays.Add(markerOverlay);

            };
            oWatcher.Start();
        }

        private void SeleccionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaseleccionada = e.RowIndex;
            txt_Descripcion.Text = dataGridView1.Rows[filaseleccionada].Cells[0].Value.ToString();
            txt_Latitud.Text = dataGridView1.Rows[filaseleccionada].Cells[1].Value.ToString();
            txt_Longitud.Text = dataGridView1.Rows[filaseleccionada].Cells[2].Value.ToString();
            marker.Position = new PointLatLng(Convert.ToDouble(txt_Latitud.Text), Convert.ToDouble(txt_Longitud.Text));
            gMapControl1.Position = marker.Position;
        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            txt_Latitud.Text = lat.ToString();
            txt_Longitud.Text = lng.ToString();
            marker.Position = new PointLatLng(lat, lng);
            markerOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(markerOverlay);
        }
    }
}
