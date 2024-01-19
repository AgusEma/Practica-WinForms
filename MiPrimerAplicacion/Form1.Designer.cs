namespace MiPrimerAplicacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnBoton = new System.Windows.Forms.Button();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.txtTextBox1 = new System.Windows.Forms.TextBox();
            this.txtTextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBoton
            // 
            this.btnBoton.BackColor = System.Drawing.Color.Chartreuse;
            this.btnBoton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoton.Image = ((System.Drawing.Image)(resources.GetObject("btnBoton.Image")));
            this.btnBoton.Location = new System.Drawing.Point(367, 206);
            this.btnBoton.Name = "btnBoton";
            this.btnBoton.Size = new System.Drawing.Size(75, 23);
            this.btnBoton.TabIndex = 0;
            this.btnBoton.UseVisualStyleBackColor = false;
            this.btnBoton.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEtiqueta.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEtiqueta.Location = new System.Drawing.Point(99, 44);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(147, 23);
            this.lblEtiqueta.TabIndex = 1;
            this.lblEtiqueta.Text = "Texto del Label";
            this.lblEtiqueta.MouseLeave += new System.EventHandler(this.lblEtiqueta_MouseLeave);
            this.lblEtiqueta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblLabel_MouseMove);
            // 
            // txtTextBox1
            // 
            this.txtTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTextBox1.Location = new System.Drawing.Point(146, 206);
            this.txtTextBox1.MaxLength = 16;
            this.txtTextBox1.Name = "txtTextBox1";
            this.txtTextBox1.Size = new System.Drawing.Size(100, 20);
            this.txtTextBox1.TabIndex = 2;
            this.txtTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTextBox_KeyPress);
            // 
            // txtTextBox2
            // 
            this.txtTextBox2.Location = new System.Drawing.Point(146, 249);
            this.txtTextBox2.Multiline = true;
            this.txtTextBox2.Name = "txtTextBox2";
            this.txtTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextBox2.Size = new System.Drawing.Size(100, 20);
            this.txtTextBox2.TabIndex = 3;
            this.txtTextBox2.Leave += new System.EventHandler(this.txtTextBox2_Leave);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTextBox2);
            this.Controls.Add(this.txtTextBox1);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.btnBoton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicación";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Click += new System.EventHandler(this.frmPrincipal_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoton;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.TextBox txtTextBox1;
        private System.Windows.Forms.TextBox txtTextBox2;
    }
}

