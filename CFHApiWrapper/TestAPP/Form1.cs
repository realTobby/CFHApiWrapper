using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAPP
{
    public partial class Form1 : Form
    {
        CFHentaiAPI.CFHentai hentai = new CFHentaiAPI.CFHentai();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox1.Load(hentai.GetNaughtyNeko());

        }
    }
}
