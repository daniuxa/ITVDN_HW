using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Media;

namespace HW3_4_Professional_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MainWindow_Loaded(this, new RoutedEventArgs());
        }

        private void cp_SelectedColorChanged_1(object sender, RoutedEventArgs e)
        {
            PropertyInfo colorProperty = typeof(Colors).GetProperties()
                .FirstOrDefault(p => Color.AreClose((Color)p.GetValue(null), (Color)colorPicker.SelectedColor));

            Label1.Content = colorProperty.Name;
            Label1.Foreground = new SolidColorBrush(colorPicker.SelectedColor.Value);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFile userStorage = IsolatedStorageFile.GetUserStoreForAssembly();
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream("TestIsolated.set", FileMode.Create, userStorage);

            using (StreamWriter userWriter = new StreamWriter(userStream))
            {
                userWriter.WriteLine(colorPicker.SelectedColor.Value);
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            IsolatedStorageFile userStorage = IsolatedStorageFile.GetUserStoreForAssembly();
            IsolatedStorageFileStream userStream = new IsolatedStorageFileStream("TestIsolated.set", FileMode.OpenOrCreate, userStorage);

            string[] files = userStorage.GetFileNames("TestIsolated.set");

            if (files.Length == 0)
            {
                MessageBox.Show("Nothing in storage");
            }
            else
            {
                // Прочитать данные из потока.
                StreamReader userReader = new StreamReader(userStream);
                string contents = userReader.ReadToEnd();

                PropertyInfo colorProperty = typeof(Colors).GetProperties()
                .FirstOrDefault(p => Color.AreClose((Color)p.GetValue(null), (Color)ColorConverter.ConvertFromString(contents)));

                Label1.Content = colorProperty.Name;
                Label1.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(contents));
            }
        }
    }
}
