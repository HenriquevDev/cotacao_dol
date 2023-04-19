using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cotação_dol
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxReal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConverter_Click(object sender, EventArgs e)
        {
            textBoxDolar.Text = (Convert.ToDouble(textBoxReal.Text) * 4.91).ToString();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxDolar.Clear();
            textBoxReal.Clear();
        }
    }
}
