using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionWindows2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //if (txtapellido.text == "")
            //    txtapellido.backcolor = color.red;
            //if (txtnombre.text == "")
            //    txtnombre.backcolor = color.red;
            //if (txtedad.text == "")
            //    txtedad.backcolor = color.red;
            //if (txtdireccion.text == "")
            //    txtdireccion.backcolor = color.red;

            
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    if (string.IsNullOrWhiteSpace(item.Text) && item.Name != "txtResultado")
                    {
                        item.BackColor = Color.Red;
                        return;
                    }
                }
            }

            txtResultado.Text = "Apellido y Nombre: " + txtApellido.Text + "\r\n" + "Edad: " + txtEdad.Text + "\r\n" + "Direccion: " + txtDireccion.Text;
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
