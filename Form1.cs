using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompressIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1(object sender, EventArgs e)
        {
            selectionFichiersACrypter.ShowDialog();
            txtbox1.Text = selectionFichiersACrypter.FileName;
                  }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void txt1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
