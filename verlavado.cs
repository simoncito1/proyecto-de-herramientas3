﻿using System;
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
    public partial class verlavado : Form
    {
        public verlavado(string dato1, string dato2, string dato3, string dato4, string dato5, string dato6)
        {
            InitializeComponent();
        }

        private void verlavado_Load(object sender, EventArgs e)
        {
            string[] programa = File.ReadAllLines("lavado.xls");
            foreach (string oscar2 in programa)
            {
                string[] values = oscar2.Split(',');
                dataGridView1.Rows.Add(values);
            }
        }
    }
}
