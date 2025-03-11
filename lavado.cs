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

namespace WindowsFormsApp1
{
    public partial class lavado : Form
    {
        public lavado()
        {
            InitializeComponent();
        }

        private void lavado_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string dato1 = txtpro.Text;
            string dato2 = comboBox2.Text;
            string dato3 = comboBox1.Text;
            string dato4 = txtdocu.Text;
            string dato5 = txtplaca.Text;
            string dato6 = txtprecio.Text;

            verlavado form3 = new verlavado(dato1, dato2, dato3, dato4, dato5, dato6);

            using (StreamWriter sw = new StreamWriter("lavado.xls", true))
            {
                sw.WriteLine($"{dato1}, {dato2}, {dato3}, {dato4}, {dato5}, {dato6}");
            }
            MessageBox.Show("Guardado 👍");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string dato1 = txtpro.Text;
            string dato2 = comboBox2.Text;
            string dato3 = comboBox1.Text;
            string dato4 = txtdocu.Text;
            string dato5 = txtplaca.Text;
            string dato6 = txtprecio.Text;

            verlavado lavado = new verlavado(dato1, dato2, dato3, dato4, dato5, dato6);
            lavado.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtpro.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
            txtdocu.Text = "";
            txtplaca.Text = "";
            txtprecio.Text = "";
        }
    }
}
