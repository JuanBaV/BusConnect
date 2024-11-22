
namespace BusConnectV2
{
    partial class frmMenuUsuarioSuscripciones
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
            this.buttonSuscribirse = new System.Windows.Forms.Button();
            this.comboBoxLineas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSuscribirse
            // 
            this.buttonSuscribirse.Location = new System.Drawing.Point(47, 95);
            this.buttonSuscribirse.Name = "buttonSuscribirse";
            this.buttonSuscribirse.Size = new System.Drawing.Size(75, 23);
            this.buttonSuscribirse.TabIndex = 3;
            this.buttonSuscribirse.Text = "suscribirse";
            this.buttonSuscribirse.UseVisualStyleBackColor = true;
            this.buttonSuscribirse.Click += new System.EventHandler(this.buttonSuscribirse_Click);
            // 
            // comboBoxLineas
            // 
            this.comboBoxLineas.FormattingEnabled = true;
            this.comboBoxLineas.Location = new System.Drawing.Point(47, 50);
            this.comboBoxLineas.Name = "comboBoxLineas";
            this.comboBoxLineas.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLineas.TabIndex = 2;
            // 
            // frmMenuUsuarioSuscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 248);
            this.Controls.Add(this.buttonSuscribirse);
            this.Controls.Add(this.comboBoxLineas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuUsuarioSuscripciones";
            this.Text = "frmMenuUsuarioSuscripciones";
            this.Load += new System.EventHandler(this.frmMenuUsuarioSuscripciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSuscribirse;
        private System.Windows.Forms.ComboBox comboBoxLineas;
    }
}