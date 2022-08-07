using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW6Extra_Professional_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                ReadAssembly(openFileDialog.FileName);
            }
        }

        private void ReadAssembly(string path)
        {
            Assembly assembly;
            try
            {
                assembly = Assembly.LoadFile(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                InfoFileTextBlock.Text += type.FullName + Environment.NewLine;

                MethodInfo[] methods = type.GetMethods();
                if (methods != null)
                {
                    InfoFileTextBlock.Text += "Methods" + Environment.NewLine;
                    foreach (var item in methods)
                    {
                        InfoFileTextBlock.Text += item.Name + Environment.NewLine;
                    }
                }

                PropertyInfo[] Prop = type.GetProperties();
                if (Prop != null)
                {
                    InfoFileTextBlock.Text += "Propreties" + Environment.NewLine;
                    foreach (var item in Prop)
                    {
                        InfoFileTextBlock.Text += item.Name + Environment.NewLine;
                    }
                }

            }
        }
    }
}
