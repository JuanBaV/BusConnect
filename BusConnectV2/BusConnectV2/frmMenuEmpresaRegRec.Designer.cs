
namespace BusConnectV2
{
    partial class frmMenuEmpresaRegRec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textRamal = new System.Windows.Forms.TextBox();
            this.btnGuardarRuta = new System.Windows.Forms.Button();
            this.txt_Latitud = new System.Windows.Forms.TextBox();
            this.txt_Longitud = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.btnAgregarPunto = new System.Windows.Forms.Button();
            this.btnEliminarPunto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGenerarRuta = new System.Windows.Forms.Button();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textRamal
            // 
            this.textRamal.BackColor = System.Drawing.Color.PowderBlue;
            this.textRamal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textRamal.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRamal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textRamal.Location = new System.Drawing.Point(12, 9);
            this.textRamal.Name = "textRamal";
            this.textRamal.Size = new System.Drawing.Size(167, 19);
            this.textRamal.TabIndex = 125;
            this.textRamal.Text = "RAMAL";
            this.textRamal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGuardarRuta
            // 
            this.btnGuardarRuta.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGuardarRuta.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnGuardarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarRuta.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardarRuta.Location = new System.Drawing.Point(483, 193);
            this.btnGuardarRuta.Name = "btnGuardarRuta";
            this.btnGuardarRuta.Size = new System.Drawing.Size(169, 23);
            this.btnGuardarRuta.TabIndex = 124;
            this.btnGuardarRuta.Text = "GUARDAR RUTA";
            this.btnGuardarRuta.UseVisualStyleBackColor = false;
            this.btnGuardarRuta.Click += new System.EventHandler(this.btnGuardarRuta_Click);
            // 
            // txt_Latitud
            // 
            this.txt_Latitud.BackColor = System.Drawing.Color.PowderBlue;
            this.txt_Latitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Latitud.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Latitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Latitud.Location = new System.Drawing.Point(483, 44);
            this.txt_Latitud.Name = "txt_Latitud";
            this.txt_Latitud.Size = new System.Drawing.Size(167, 19);
            this.txt_Latitud.TabIndex = 123;
            this.txt_Latitud.Text = "LATITUD";
            this.txt_Latitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Longitud
            // 
            this.txt_Longitud.BackColor = System.Drawing.Color.PowderBlue;
            this.txt_Longitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Longitud.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Longitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Longitud.Location = new System.Drawing.Point(483, 69);
            this.txt_Longitud.Name = "txt_Longitud";
            this.txt_Longitud.Size = new System.Drawing.Size(167, 19);
            this.txt_Longitud.TabIndex = 122;
            this.txt_Longitud.Text = "LONGITUD";
            this.txt_Longitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.BackColor = System.Drawing.Color.PowderBlue;
            this.txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Descripcion.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Descripcion.Location = new System.Drawing.Point(483, 19);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(167, 19);
            this.txt_Descripcion.TabIndex = 121;
            this.txt_Descripcion.Text = "DESCRIPCION";
            this.txt_Descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregarPunto
            // 
            this.btnAgregarPunto.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAgregarPunto.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnAgregarPunto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarPunto.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPunto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarPunto.Location = new System.Drawing.Point(483, 106);
            this.btnAgregarPunto.Name = "btnAgregarPunto";
            this.btnAgregarPunto.Size = new System.Drawing.Size(169, 23);
            this.btnAgregarPunto.TabIndex = 120;
            this.btnAgregarPunto.Text = "AGREGAR PUNTO";
            this.btnAgregarPunto.UseVisualStyleBackColor = false;
            this.btnAgregarPunto.Click += new System.EventHandler(this.btnAgregarPunto_Click);
            // 
            // btnEliminarPunto
            // 
            this.btnEliminarPunto.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEliminarPunto.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnEliminarPunto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarPunto.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPunto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEliminarPunto.Location = new System.Drawing.Point(483, 135);
            this.btnEliminarPunto.Name = "btnEliminarPunto";
            this.btnEliminarPunto.Size = new System.Drawing.Size(169, 23);
            this.btnEliminarPunto.TabIndex = 119;
            this.btnEliminarPunto.Text = "ELIMINAR PUNTO";
            this.btnEliminarPunto.UseVisualStyleBackColor = false;
            this.btnEliminarPunto.Click += new System.EventHandler(this.btnEliminarPunto_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(481, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(169, 224);
            this.dataGridView1.TabIndex = 118;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SeleccionarRegistro);
            // 
            // btnGenerarRuta
            // 
            this.btnGenerarRuta.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGenerarRuta.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;
            this.btnGenerarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarRuta.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerarRuta.Location = new System.Drawing.Point(483, 164);
            this.btnGenerarRuta.Name = "btnGenerarRuta";
            this.btnGenerarRuta.Size = new System.Drawing.Size(169, 23);
            this.btnGenerarRuta.TabIndex = 117;
            this.btnGenerarRuta.Text = "GENERAR RUTA";
            this.btnGenerarRuta.UseVisualStyleBackColor = false;
            this.btnGenerarRuta.Click += new System.EventHandler(this.btnGenerarRuta_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 44);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(463, 394);
            this.gMapControl1.TabIndex = 126;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // frmMenuEmpresaRegRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.textRamal);
            this.Controls.Add(this.btnGuardarRuta);
            this.Controls.Add(this.txt_Latitud);
            this.Controls.Add(this.txt_Longitud);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.btnAgregarPunto);
            this.Controls.Add(this.btnEliminarPunto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGenerarRuta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuEmpresaRegRec";
            this.Text = "frmMenuEmpresaRegRec";
            this.Load += new System.EventHandler(this.frmMenuEmpresaRegRec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textRamal;
        private System.Windows.Forms.Button btnGuardarRuta;
        private System.Windows.Forms.TextBox txt_Latitud;
        private System.Windows.Forms.TextBox txt_Longitud;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Button btnAgregarPunto;
        private System.Windows.Forms.Button btnEliminarPunto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGenerarRuta;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}