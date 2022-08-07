using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Content : Form
    {
        public Content()
        {
            InitializeComponent();
        }

        public Content(out List<string> contents)
        {
            InitializeComponent();
            contents = new List<string>();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Content_Load(object sender, EventArgs e)
        {
            ListBox.Items.Add("Methods");
            ListBox.Items.Add("Fields");
            ListBox.Items.Add("Properties");
            ListBox.Items.Add("Constructors");
        }

        private void Content_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
