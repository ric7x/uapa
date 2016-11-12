using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime nacimiento = new DateTime(Convert.ToInt32(txtAno.Text), Convert.ToInt32(txtMes.Text), Convert.ToInt32(txtDia.Text));

            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
            TimeSpan ts = DateTime.Today - nacimiento;

            txtAnio.Text = edad.ToString();
            txtDias.Text = ts.ToString();
            txtMeses.Text = (int.Parse(txtAnio.Text) * 12).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
