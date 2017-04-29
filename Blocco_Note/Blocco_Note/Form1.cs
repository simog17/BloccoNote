using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Blocco_Note
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string getPath()
        {
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + \\
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(getPath(), textBox1.text);
        }
    }
}
