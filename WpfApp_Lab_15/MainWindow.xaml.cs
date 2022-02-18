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
using System.IO;
using System.Xaml;
using System.Windows.Markup;

namespace WpfApp_Lab_15
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            doc.ClearValue(FlowDocumentScrollViewer.DocumentProperty);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = File.Open("1.xaml", FileMode.Open))
            {
                doc.Document = System.Windows.Markup.XamlReader.Load(fs) as FlowDocument;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (FileStream fs = File.Open("1.xaml", FileMode.Create))
            {
                System.Windows.Markup.XamlWriter.Save(doc.Document, fs);
            }
        }
    }
}


