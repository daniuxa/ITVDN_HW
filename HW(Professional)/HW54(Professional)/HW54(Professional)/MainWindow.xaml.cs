using System;
using System.Collections.Generic;
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
using System.Xml;

/*Создайте приложение WPF Application, в главном окне которого поместите любой текст. Также,
должно быть окно настроек (можно реализовать с помощью TabControl). Пользователь может
изменять настройки. При повторном запуске приложения настройки должны оставаться
прежними. Реализуйте два варианта (в одном приложении или двух разных): 1) сохранение
настроек в конфигурационном файле; 2) сохранение настроек в реестре.
В окне настроек реализуйте следующие опции: цвет фона, цвет текста, размер шрифта, стиль
шрифта, а также кнопку «Сохранить». Для выбора цвета воспользуйтесь ColorPicker-ом по
примеру задания из Урока №3.*/

namespace HW54_Professional_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach (FontFamily item in Fonts.SystemFontFamilies)
            {
                FontsPicker.Items.Add(item.Source);
            }
            for (int i = 1; i < 50; i++)
            {
                SizePicker.Items.Add(i);
            }
        }
        private void BackColorsPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            TextLabel.Background = new SolidColorBrush(BackColorsPicker.SelectedColor.Value);
        }

        private void FontsPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TextLabel.FontFamily = new FontFamily(FontsPicker.SelectedItem.ToString());
        }

        private void FontColorsPicker_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            TextLabel.Foreground = new SolidColorBrush(FontColorsPicker.SelectedColor.Value);
        }

        private void SizePick_SelectedChanged(object sender, SelectionChangedEventArgs e)
        {
            TextLabel.FontSize = Int32.Parse(SizePicker.SelectedItem.ToString());
        }

        private static XmlDocument loadConfigDocument()
        {
            XmlDocument doc = null;
            try
            {
                doc = new XmlDocument();
                doc.Load(Assembly.GetExecutingAssembly().Location + ".config");
                return doc;
            }
            catch (System.IO.FileNotFoundException e)
            {
                throw new Exception("No configuration file found.", e);
            }
        }

        private void SaveSettings()
        {
            // Сохранение происходит при помощи работы с XML.
            XmlDocument doc = loadConfigDocument();

            // Открываем узел appSettings, в котором содержится перечень настроек.
            XmlNode node = doc.SelectSingleNode("//appSettings");
            /*if (node == null)
            {
                var xmlWriter = new XmlTextWriter(Assembly.GetExecutingAssembly().Location + ".config", null);
                xmlWriter.WriteStartElement("//appSettings");
                xmlWriter.WriteEndElement();
            }
            node = doc.SelectSingleNode("//appSettings");*/

            XmlElement BackColorElement = node.SelectSingleNode(string.Format("//add[@key='BackColor']")) as XmlElement;
            XmlElement FontColorElement = node.SelectSingleNode(string.Format("//add[@key='FontColor']")) as XmlElement;
            XmlElement FontElement = node.SelectSingleNode(string.Format("//add[@key='Font']")) as XmlElement;
            XmlElement SizeElement = node.SelectSingleNode(string.Format("//add[@key='Size']")) as XmlElement;

            if (BackColorElement != null && FontColorElement != null && FontElement != null && SizeElement != null)
            {
                BackColorElement.SetAttribute("value", BackColorsPicker.SelectedColor.Value.ToString());
                FontColorElement.SetAttribute("value", FontColorsPicker.SelectedColor.Value.ToString());
                FontElement.SetAttribute("value", FontsPicker.SelectedItem.ToString());
                SizeElement.SetAttribute("value", SizePicker.SelectedItem.ToString());
            }
            else
            {
                // Иначе: создаем строку и формируем в ней пару [ключ]-[значение].
                BackColorElement = doc.CreateElement("add");
                BackColorElement.SetAttribute("key", "BackColor");
                BackColorElement.SetAttribute("value", BackColorsPicker.SelectedColor.Value.ToString());
                node.AppendChild(BackColorElement);

                FontColorElement = doc.CreateElement("add");
                FontColorElement.SetAttribute("key", "FontColor");
                FontColorElement.SetAttribute("value", FontColorsPicker.SelectedColor.Value.ToString());
                node.AppendChild(FontColorElement);

                FontElement = doc.CreateElement("add");
                FontElement.SetAttribute("key", "Font");
                FontElement.SetAttribute("value", FontsPicker.SelectedItem.ToString());
                node.AppendChild(FontElement);

                SizeElement = doc.CreateElement("add");
                SizeElement.SetAttribute("key", "Size");
                SizeElement.SetAttribute("value", SizePicker.SelectedItem.ToString());
                node.AppendChild(SizeElement);
            }

            // Сохраняем результат модификации.
            doc.Save(Assembly.GetExecutingAssembly().Location + ".config");
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveSettings();
        }
    }
}
