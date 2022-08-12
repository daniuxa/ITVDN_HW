using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW13_Professional_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SomeMethode()
        {
            Thread.Sleep(10000);
        }

        private void IsCompleteButton_Click(object sender, EventArgs e)
        {
            Action action = SomeMethode;
            IAsyncResult asyncResult = action.BeginInvoke(null, null);
            while (!asyncResult.IsCompleted)
            { }
            MessageBox.Show("IsComplete end");
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Action action = SomeMethode;
            IAsyncResult asyncResult = action.BeginInvoke(null, null);
            action.EndInvoke(asyncResult);
            MessageBox.Show("EndInvoke end");
        }

        private void CallbackButton_Click(object sender, EventArgs e)
        {
            Action action = SomeMethode;
            action.BeginInvoke(callback, action);
        }

        private void callback(IAsyncResult ar)
        {
            Action action = ar.AsyncState as Action;
            if (action != null)
            {
                action.EndInvoke(ar);
                MessageBox.Show("EndInvoke end");
            }
        }
    }
}
