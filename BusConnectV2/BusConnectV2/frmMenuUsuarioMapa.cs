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
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Device.Location;

namespace BusConnectV2
{
    public partial class frmMenuUsuarioMapa : Form
    {
        public frmMenuUsuarioMapa()
        {
            InitializeComponent();
        }

        N_Users objnuser = new N_Users();
        public double a;
        public double b;
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        private void frmMenuUsuarioMapa_Load(object sender, EventArgs e)
        {
            if (Controles.lang == 1)
            {
                label1.Text = EN.Linea;
                label2.Text = EN.Ramal;


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

            DataTable dt = new DataTable();
            dt = objnuser.N_GetLineas();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "CodLinea";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int linea = int.Parse(comboBox1.Text);
                DataTable dtRamales = new DataTable();
                dtRamales = objnuser.N_GetRamal(linea);
                comboBox2.DataSource = dtRamales;
                comboBox2.DisplayMember = "CodRamal";
            }
            catch (Exception)
            {

                int a;
            }
        }


        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarRuta_Click(object sender, EventArgs e)
        {
            
            gMapControl1.Overlays.Clear();
            GMapOverlay Ruta = new GMapOverlay("Capa Ruta");
            List<PointLatLng> puntos = new List<PointLatLng>();
            double lat;
            double lng;
            for (int filas = 0; filas < dataGridView1.Rows.Count - 2; filas++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[filas].Cells[2].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[filas].Cells[3].Value);
                puntos.Add(new PointLatLng(lat, lng));
                
                //PointLatLng spawn = new PointLatLng(Convert.ToDouble(obj.Latitud), Convert.ToDouble(obj.Longitud));
                //marker = new GMarkerGoogle(spawn, GMarkerGoogleType.green);
                //markerOverlay = new GMapOverlay("Marcador");
                //markerOverlay.Markers.Add(marker);
                //gMapControl1.Overlays.Add(markerOverlay);
            }
            GMapRoute PuntosRuta = new GMapRoute(puntos, "Ruta");
            Ruta.Routes.Add(PuntosRuta);
            gMapControl1.Overlays.Add(Ruta);
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ramal = int.Parse(comboBox2.Text);
                DataTable dtUbicaciones = new DataTable();
                dtUbicaciones = objnuser.N_GetUbi(ramal);
                dataGridView1.DataSource = dtUbicaciones;
            }
            catch (Exception)
            {

                int a;
            }
        }
    }
}

