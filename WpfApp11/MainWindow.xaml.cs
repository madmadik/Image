using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfApp11
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
        private void Button_Find(object sender, RoutedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog
            {
                Title = "Найдите картинку...",
                InitialDirectory = System.IO.Path.GetFullPath("."),
            };
            if (file.ShowDialog() == true)
            {
                picture.Source = new BitmapImage(new Uri(file.FileName));
            }
            info.Text = file.FileName.Substring(file.FileName.LastIndexOf("\\")).Remove(0, 1);
        }
    }
}
