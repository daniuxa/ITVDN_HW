using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        // ��� ������ ������ Assembly - ����� ����������� ��������� ������, 
        // ���������� � ������ ������ � �������� ���������� (������� ����������),
        // � ��� �� �������� ���������� � ����� ������.
        Assembly assembly = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                // ������ ������ ������� ����� ����������� ������.
                string path = openFileDialog.FileName;

                /*Content content = new Content();
                content.ShowDialog(this);*/

                try
                {
                    assembly = Assembly.LoadFile(path);

                    textBox.Text += "������    " + path + "  -  ������� ���������" + Environment.NewLine + Environment.NewLine;
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                // ����� ���������� � ���� ����� � ������.
                textBox.Text += "������ ���� ����� � ������:     " + assembly.FullName + Environment.NewLine + Environment.NewLine;

                Type[] types = assembly.GetTypes();

                foreach (Type type in types)
                {
                    //textBox.Text += "���:  " + type + Environment.NewLine;
                    //var methods = type.GetMethods();
                    //if (methods!=null)
                    //{
                    //    foreach (var method in methods)
                    //    {
                    //        string methStr = "�����:" + method.Name + "\n";
                    //        var methodBody = method.GetMethodBody();
                    //        if (methodBody != null)
                    //        {
                    //            var byteArray = methodBody.GetILAsByteArray();
                         
                    //            foreach (var b in byteArray)
                    //            {
                    //                methStr += b + ":";
                    //            }
                    //        }
                    //        textBox.Text += methStr+Environment.NewLine;
                    //    }
                    //}
                    var attributes = type.GetCustomAttributes();
                    if (attributes != null)
                    {
                        foreach (var item in attributes)
                        {
                            string attrStr = "Attribute: " + item.GetType().Name + Environment.NewLine;
                            textBox.Text += attrStr + Environment.NewLine;
                        }
                    }
                }


            }
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}