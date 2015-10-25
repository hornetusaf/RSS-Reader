using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Xml;
using Microsoft.Win32;


namespace LectorRSS
{
    public partial class Form1 : Form
    {
        String[,] rssData;
        public bool prx;
        public String usuario;
        public String contraseña;
        public String direccion;
        public String puerto;

        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            descripcionWebBrowser.ScriptErrorsSuppressed = true;
            string linea;

            using (var file = new StreamReader("listado.txt"))
                while ((linea = file.ReadLine()) != null)
                {
                    canalesListBox.Items.Add(linea);
                }

            rssData = null;
            prx = false;
            usuario = "";
            contraseña = "";
            direccion = "150.187.65.3";
            puerto = "3128";
        }

        private String[,] getRssData(String URL)
        {
            WebRequest Solicitud;
            WebResponse Respuesta;
            try
            {
                if (prx)
                {
                    Solicitud = WebRequest.Create(URL);

                    IWebProxy proxy = Solicitud.Proxy;
                    WebProxy myProxy = new WebProxy();
                    Uri newUri = new Uri("http://" + direccion + ":" + puerto);
                    myProxy.Address = newUri;
                    myProxy.Credentials = new NetworkCredential(usuario, contraseña);
                    Solicitud.Proxy = myProxy;

                    Respuesta = Solicitud.GetResponse();
                }
                else
                {
                    Solicitud = WebRequest.Create(URL);
                    Respuesta = Solicitud.GetResponse();
                }


                Stream rssStream = Respuesta.GetResponseStream();
                XmlDocument rssDoc = new XmlDocument();

                rssDoc.Load(rssStream);

                XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel");
                XmlNode rssNodoTitulo;
                rssNodoTitulo = rssItems.Item(0).SelectSingleNode("title");

                if (rssNodoTitulo != null)
                    fuenteLabel.Text = "Fuente: " + rssNodoTitulo.InnerText;

                rssItems = rssDoc.SelectNodes("rss/channel/item");

                String[,] tempRssData = new String[500, 3];

                for (int i = 0; i < rssItems.Count; i++)
                {
                    System.Xml.XmlNode rssNodo;

                    rssNodo = rssItems.Item(i).SelectSingleNode("title");
                    if (rssNodo != null)
                        tempRssData[i, 0] = rssNodo.InnerText;
                    else
                        tempRssData[i, 0] = "";

                    rssNodo = rssItems.Item(i).SelectSingleNode("description");
                    if (rssNodo != null)
                        tempRssData[i, 1] = rssNodo.InnerText;
                    else
                        tempRssData[i, 1] = "";

                    rssNodo = rssItems.Item(i).SelectSingleNode("link");
                    if (rssNodo != null)
                        tempRssData[i, 2] = rssNodo.InnerText;
                    else
                        tempRssData[i, 2] = "";

                    //obtener fechas
                }

                return tempRssData;
            }
            catch (Exception)
            {
                rssData = null;
                return null;
            }
        }

        private void titulosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rssData[titulosComboBox.SelectedIndex, 1] != null)
            {
                descripcionTextBox.Text = rssData[titulosComboBox.SelectedIndex, 1];                
                descripcionWebBrowser.Navigate(rssData[titulosComboBox.SelectedIndex, 2]);                
            }
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            if (fuenteTextBox.Text != "")
            {
                canalesListBox.Items.Add(fuenteTextBox.Text);
                var lineas = canalesListBox.Items.Cast<String>().ToArray();
                File.WriteAllLines("listado.txt", lineas);
                fuenteTextBox.Text = "";
            }
        }

        private void borrarButton_Click(object sender, EventArgs e)
        {
            if (canalesListBox.SelectedIndex >= 0)
                canalesListBox.Items.RemoveAt(canalesListBox.SelectedIndex);

            var lineas = canalesListBox.Items.Cast<String>().ToArray();
            File.WriteAllLines("listado.txt", lineas);
            fuenteTextBox.Text = "";
            fuenteLabel.Text = "";
            titulosComboBox.Items.Clear();
            titulosComboBox.Text = "";
            descripcionTextBox.Clear();
            descripcionWebBrowser.Navigate("about:blank");
        }

        private void canalesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            titulosComboBox.Items.Clear();
            rssData = getRssData(canalesListBox.GetItemText(canalesListBox.SelectedItem));

            if (rssData != null)
            {
                for (int i = 0; i < rssData.GetLength(0); i++)
                {
                    if (rssData[i, 0] != null)
                        titulosComboBox.Items.Add(rssData[i, 0]);

                    titulosComboBox.SelectedIndex = 0;
                }
            }
        }

        private void proxyButton_Click(object sender, EventArgs e)
        {
            Form2 credencialesForm = new Form2();
            credencialesForm.usuario = usuario;
            credencialesForm.contraseña = contraseña;
            credencialesForm.direccion = direccion;
            credencialesForm.puerto = puerto;
            credencialesForm.prx = prx;
            credencialesForm.ShowDialog();

            usuario = credencialesForm.usuario;
            contraseña = credencialesForm.contraseña;
            direccion = credencialesForm.direccion;
            puerto = credencialesForm.puerto;
            prx = credencialesForm.prx;
        }       
    }
}
