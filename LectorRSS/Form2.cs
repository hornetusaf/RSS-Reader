using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace LectorRSS
{
    public partial class Form2 : Form
    {
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string direccion { get; set; }
        public string puerto { get; set; }
        public bool prx { get; set; }

        public Form2()
        {
            InitializeComponent();

            usuarioTextBox.KeyDown += new KeyEventHandler(ut_KeyDown);
            contraseñaTextBox.KeyDown += new KeyEventHandler(ct_KeyDown);

            if (!prx)
            {
                proxyCheckBox.Checked = false;
                direccionTextBox.Enabled = false;
                puertoTextBox.Enabled = false;
                usuarioTextBox.Enabled = false;
                contraseñaTextBox.Enabled = false;
            }
            else
            {
                proxyCheckBox.Checked = true;
                direccionTextBox.Enabled = true;
                puertoTextBox.Enabled = true;
                usuarioTextBox.Enabled = true;
                contraseñaTextBox.Enabled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            direccionTextBox.Text = direccion;
            puertoTextBox.Text = puerto;
            usuarioTextBox.Text = usuario;
            contraseñaTextBox.Text = contraseña;
            proxyCheckBox.Checked = prx;
        }

        private void aceptarButton_Click(object sender, EventArgs e)
        {
            prx = proxyCheckBox.Checked;
            direccion = direccionTextBox.Text;
            puerto = puertoTextBox.Text;
            usuario = usuarioTextBox.Text;
            contraseña = contraseñaTextBox.Text;
            Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        void ut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                prx = proxyCheckBox.Checked;
                direccion = direccionTextBox.Text;
                puerto = puertoTextBox.Text;
                usuario = usuarioTextBox.Text;
                contraseña = contraseñaTextBox.Text;
                Close();
            }
        }

        void ct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                prx = proxyCheckBox.Checked;
                direccion = direccionTextBox.Text;
                puerto = puertoTextBox.Text;
                usuario = usuarioTextBox.Text;
                contraseña = contraseñaTextBox.Text;
                Close();
            }
        }

        private void proxyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (proxyCheckBox.Checked == false)
            {
                direccionTextBox.Enabled = false;
                puertoTextBox.Enabled = false;
                usuarioTextBox.Enabled = false;
                contraseñaTextBox.Enabled = false;
            }
            else
            {
                direccionTextBox.Enabled = true;
                puertoTextBox.Enabled = true;
                usuarioTextBox.Enabled = true;
                contraseñaTextBox.Enabled = true;
            }
        }

        private void direccionTextBox_Leave(object sender, EventArgs e)
        {
            string ip = direccionTextBox.Text;
            string[] parts = ip.Split('.');
            if (parts.Length < 4)
            {
                MessageBox.Show("Ingrese una direccion ip valida.");
            }
            else
            {
                foreach (string part in parts)
                {
                    byte checkPart = 0;
                    if (!byte.TryParse(part, out checkPart))
                    {
                        MessageBox.Show("Ingrese una direccion ip valida.");
                    }
                }
                // formato de ipv4 valido
            }
        }

        private void puertoTextBox_Leave(object sender, EventArgs e)
        {
            int i;
            bool num = int.TryParse(puertoTextBox.Text, out i);

            if (!num)
                MessageBox.Show("Ingrese numero de puerto valido.");
        }
    }
}
