using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Servicios : Form
    {
        public Servicios(string usuario, string contraseña)
        {
            InitializeComponent();
            lavado lavado = new lavado();
            parqueadero parqueadero = new parqueadero();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lavado lavado = new lavado();
            parqueadero parqueadero = new parqueadero();
        }
    }
}
