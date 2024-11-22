
namespace BusConnectV2
{
    partial class frmMenuUsuarioConsultas
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
            this.labelMConsultas = new System.Windows.Forms.Label();
            this.labelNroConsulta = new System.Windows.Forms.Label();
            this.labelRespuesta = new System.Windows.Forms.Label();
            this.labelCosnulta = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonEnviarConsulta = new System.Windows.Forms.Button();
            this.richTextBoxConsulta = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMConsultas
            // 
            this.labelMConsultas.AutoSize = true;
            this.labelMConsultas.Location = new System.Drawing.Point(9, 306);
            this.labelMConsultas.Name = "labelMConsultas";
            this.labelMConsultas.Size = new System.Drawing.Size(72, 13);
            this.labelMConsultas.TabIndex = 17;
            this.labelMConsultas.Text = "Mis Consultas";
            // 
            // labelNroConsulta
            // 
            this.labelNroConsulta.AutoSize = true;
            this.labelNroConsulta.Location = new System.Drawing.Point(265, 12);
            this.labelNroConsulta.Name = "labelNroConsulta";
            this.labelNroConsulta.Size = new System.Drawing.Size(82, 13);
            this.labelNroConsulta.TabIndex = 16;
            this.labelNroConsulta.Text = "Nro de consulta";
            // 
            // labelRespuesta
            // 
            this.labelRespuesta.AutoSize = true;
            this.labelRespuesta.Location = new System.Drawing.Point(265, 58);
            this.labelRespuesta.Name = "labelRespuesta";
            this.labelRespuesta.Size = new System.Drawing.Size(58, 13);
            this.labelRespuesta.TabIndex = 15;
            this.labelRespuesta.Text = "Respuesta";
            // 
            // labelCosnulta
            // 
            this.labelCosnulta.AutoSize = true;
            this.labelCosnulta.Location = new System.Drawing.Point(9, 21);
            this.labelCosnulta.Name = "labelCosnulta";
            this.labelCosnulta.Size = new System.Drawing.Size(85, 13);
            this.labelCosnulta.TabIndex = 14;
            this.labelCosnulta.Text = "Escribir Consulta";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(268, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(220, 193);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(266, 81);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonEnviarConsulta
            // 
            this.buttonEnviarConsulta.Location = new System.Drawing.Point(12, 257);
            this.buttonEnviarConsulta.Name = "buttonEnviarConsulta";
            this.buttonEnviarConsulta.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviarConsulta.TabIndex = 10;
            this.buttonEnviarConsulta.Text = "Enviar";
            this.buttonEnviarConsulta.UseVisualStyleBackColor = true;
            this.buttonEnviarConsulta.Click += new System.EventHandler(this.buttonEnviarConsulta_Click);
            // 
            // richTextBoxConsulta
            // 
            this.richTextBoxConsulta.Location = new System.Drawing.Point(12, 37);
            this.richTextBoxConsulta.Name = "richTextBoxConsulta";
            this.richTextBoxConsulta.Size = new System.Drawing.Size(220, 193);
            this.richTextBoxConsulta.TabIndex = 9;
            this.richTextBoxConsulta.Text = "";
            // 
            // frmMenuUsuarioConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 412);
            this.Controls.Add(this.labelMConsultas);
            this.Controls.Add(this.labelNroConsulta);
            this.Controls.Add(this.labelRespuesta);
            this.Controls.Add(this.labelCosnulta);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEnviarConsulta);
            this.Controls.Add(this.richTextBoxConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuUsuarioConsultas";
            this.Text = "frmMenuUsuarioConsultas";
            this.Load += new System.EventHandler(this.frmMenuUsuarioConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMConsultas;
        private System.Windows.Forms.Label labelNroConsulta;
        private System.Windows.Forms.Label labelRespuesta;
        private System.Windows.Forms.Label labelCosnulta;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonEnviarConsulta;
        private System.Windows.Forms.RichTextBox richTextBoxConsulta;
    }
}