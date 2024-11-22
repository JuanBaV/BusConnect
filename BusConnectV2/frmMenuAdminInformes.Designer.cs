
namespace BusConnectV2
{
    partial class frmMenuAdminInformes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DSInformeUsuarios = new BusConnectV2.DSInformeUsuarios();
            this.avisosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSInformeAvisos = new BusConnectV2.DSInformeAvisos();
            this.avisosTableAdapter = new BusConnectV2.DSInformeAvisosTableAdapters.AvisosTableAdapter();
            this.UsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsuariosTableAdapter = new BusConnectV2.DSInformeUsuariosTableAdapters.UsuariosTableAdapter();
            this.dSInformeUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSInformeUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avisosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSInformeAvisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSInformeUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Avisos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuarios";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.avisosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BusConnectV2.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(749, 217);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.usuariosBindingSource1;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "BusConnectV2.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 277);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(749, 217);
            this.reportViewer2.TabIndex = 3;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "Usuarios";
            this.usuariosBindingSource1.DataSource = this.DSInformeUsuarios;
            // 
            // DSInformeUsuarios
            // 
            this.DSInformeUsuarios.DataSetName = "DSInformeUsuarios";
            this.DSInformeUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avisosBindingSource
            // 
            this.avisosBindingSource.DataMember = "Avisos";
            this.avisosBindingSource.DataSource = this.dSInformeAvisos;
            // 
            // dSInformeAvisos
            // 
            this.dSInformeAvisos.DataSetName = "DSInformeAvisos";
            this.dSInformeAvisos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // avisosTableAdapter
            // 
            this.avisosTableAdapter.ClearBeforeFill = true;
            // 
            // UsuariosBindingSource
            // 
            this.UsuariosBindingSource.DataMember = "Usuarios";
            this.UsuariosBindingSource.DataSource = this.DSInformeUsuarios;
            // 
            // UsuariosTableAdapter
            // 
            this.UsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // dSInformeUsuariosBindingSource
            // 
            this.dSInformeUsuariosBindingSource.DataSource = this.DSInformeUsuarios;
            this.dSInformeUsuariosBindingSource.Position = 0;
            // 
            // frmMenuAdminInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 504);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMenuAdminInformes";
            this.Text = "frmMenuAdminInformes";
            this.Load += new System.EventHandler(this.frmMenuAdminInformes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSInformeUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avisosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSInformeAvisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSInformeUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DSInformeAvisos dSInformeAvisos;
        private System.Windows.Forms.BindingSource avisosBindingSource;
        private DSInformeAvisosTableAdapters.AvisosTableAdapter avisosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource UsuariosBindingSource;
        private DSInformeUsuarios DSInformeUsuarios;
        private DSInformeUsuariosTableAdapters.UsuariosTableAdapter UsuariosTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private System.Windows.Forms.BindingSource dSInformeUsuariosBindingSource;
    }
}