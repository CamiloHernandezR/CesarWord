using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cesarWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnLimpiar.Enabled = false;
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            openFile.Filter = "txt files (*.txt)|*txt";
            openFile.InitialDirectory = "C:\\Users\\magnu\\Desktop\\CuatriActual\\Seguridad\\CantidadDeInformacion\\CantidadInformacion";

            if (openFile.ShowDialog() == DialogResult.OK && openFile.ToString() != "")
            {
                string archivo = openFile.FileName;
                if (File.Exists(archivo))
                {
                    txtCadena.Text = File.ReadAllText(archivo);
                }
            }
        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
           
            if (txtLlave.Text != "" && txtCadena.Text != "")
            {
                List<char> alfabeto = new List<char>();

                char[] abecedario = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890,.-();:_-¡!¿?@#$%&/= ".ToCharArray();
                alfabeto.AddRange(abecedario);
                char[] entrada = new char[txtCadena.Text.Length];
                char[] llave = new char[txtLlave.Text.Length];
                string cifrado = null;
                int con = 0;
                entrada = txtCadena.Text.ToCharArray();
                llave = txtLlave.Text.ToCharArray();
                foreach (char let in entrada)
                {
                    if (alfabeto.Contains(let))
                    {
                        int posicion = alfabeto.IndexOf(let);
                        int des = alfabeto.IndexOf(llave[con]);
                        int mov = (posicion + des) % alfabeto.Count;
                        char aux = alfabeto[mov];
                        cifrado = cifrado + aux;
                        con++;

                    }
                    else
                    {
                        cifrado = cifrado + let;
                    }
                    if (con >= llave.Count())
                    {
                        con = 0;
                    }
                }
                txtCifrado.Text = cifrado;
                btnLimpiar.Enabled = true;
            }
            else MessageBox.Show("Elementos para cifrar insuficientes");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCifrado.Text = "";
            txtCadena.Text = "";
            txtLlave.Text = "";
            btnCifrar.Enabled = false;
        }
    }
}
