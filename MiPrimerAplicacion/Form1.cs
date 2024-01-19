using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a C#");
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau chau...");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento Click", "Atención");
            //this.BackColor = Color.Blue;
            if (txtTextBox1.Text == "")
                txtTextBox1.BackColor = Color.Red;
            else
                txtTextBox1.BackColor = System.Drawing.SystemColors.Control;
        }

        private void frmPrincipal_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el boton Izquierdo", "Atencion");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el boton Derecho", "Atencion");
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el boton del Medio", "Atencion");
        }

        private void lblLabel_MouseMove(object sender, MouseEventArgs e)
        {
            lblEtiqueta.BackColor = Color.Cyan;
            lblEtiqueta.ForeColor = Color.Black;
            lblEtiqueta.Cursor = Cursors.Hand;
        }

        private void lblEtiqueta_MouseLeave(object sender, EventArgs e)
        {
            lblEtiqueta.BackColor = System.Drawing.SystemColors.Window;
            //lblEtiqueta.ForeColor = System.Drawing.SystemColors.Window;
            lblEtiqueta.Cursor = Cursors.Arrow;
        }

        private void txtTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 ||  e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtTextBox2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtTextBox2.Text.Length + " Caracteres.");
        }
    }
}
