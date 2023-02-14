namespace Tarea_2___Segundo_Semestre
{
    partial class Form1
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
            this.btnNombre = new System.Windows.Forms.Label();
            this.btnTelefono = new System.Windows.Forms.Label();
            this.lblImprimir = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.txtTelefono1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNombre
            // 
            this.btnNombre.AutoSize = true;
            this.btnNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNombre.Location = new System.Drawing.Point(66, 63);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(94, 25);
            this.btnNombre.TabIndex = 0;
            this.btnNombre.Text = "Nombre:";
            // 
            // btnTelefono
            // 
            this.btnTelefono.AutoSize = true;
            this.btnTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelefono.Location = new System.Drawing.Point(66, 132);
            this.btnTelefono.Name = "btnTelefono";
            this.btnTelefono.Size = new System.Drawing.Size(104, 25);
            this.btnTelefono.TabIndex = 1;
            this.btnTelefono.Text = "Telefono:";
            // 
            // lblImprimir
            // 
            this.lblImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImprimir.Location = new System.Drawing.Point(121, 182);
            this.lblImprimir.Name = "lblImprimir";
            this.lblImprimir.Size = new System.Drawing.Size(264, 62);
            this.lblImprimir.TabIndex = 2;
            this.lblImprimir.Click += new System.EventHandler(this.lblImprimir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(360, 98);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(190, 66);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(100, 22);
            this.txtNombre1.TabIndex = 4;
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.Location = new System.Drawing.Point(190, 135);
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono1.TabIndex = 5;
            this.txtTelefono1.TextChanged += new System.EventHandler(this.txtTelefono1_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(522, 266);
            this.Controls.Add(this.txtTelefono1);
            this.Controls.Add(this.txtNombre1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblImprimir);
            this.Controls.Add(this.btnTelefono);
            this.Controls.Add(this.btnNombre);
            this.Name = "Form1";
            this.Text = "Tarea 2 - Windows Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblImpresion;
        private System.Windows.Forms.Label btnNombre;
        private System.Windows.Forms.Label btnTelefono;
        private System.Windows.Forms.Label lblImprimir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.TextBox txtTelefono1;
    }
}

